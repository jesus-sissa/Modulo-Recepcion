Imports System.Data.SqlClient
Imports Modulo_Recepcion.FuncionesGlobales
Imports Modulo_Recepcion.Cn_Datos

Public Class Cn_Clientes

#Region "Administracion de Caset"

    Public Shared Function fn_Kardex_Catalogo_BajaAlta(ByVal IdCodigo_Barra As String, ByVal Status As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Kardex_Status", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Codigo_Barra", SqlDbType.VarChar, IdCodigo_Barra)
        Crea_Parametro(Cmd, "@Status", SqlDbType.Int, Status)
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try

    End Function
    Public Shared Function fn_Kardex_Catalogo_ObtenValores(ByVal IdCodigo_Barra As String) As DataRow

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Kardex_Caset_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Codigo_Barra", SqlDbType.Int, IdCodigo_Barra)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                MsgBox("No existe el registro solicitado", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    

#End Region

#Region "Control Caset"

    Public Shared Function fn_Kardex_Caset_Disponibles(ByVal lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            lsv.Actualizar(cmd, "Id_Caset")
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_Caset_AsignaCliente(ByVal lsv As cp_Listview, ByVal Id_Cliente As Integer, ByVal Fecha As Date)
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim tr As SqlTransaction = Nothing

        Try
            cnn = Crea_ConexionSTD()
            tr = crear_Trans(cnn)

            For Each item As ListViewItem In lsv.CheckedItems

                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_CasetAsignaCliente_Insert")
                Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, CInt(item.Tag))
                Crea_Parametro(cmd, "@Id_Cliente_Asignado", SqlDbType.Int, Id_Cliente)
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                Crea_Parametro(cmd, "@Usuario_Asigna", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Fecha_Asigna", SqlDbType.Date, Fecha)
                Crea_Parametro(cmd, "@Estacion_Asigna", SqlDbType.VarChar, EstacioN)
                EjecutarNonQueryT(cmd)

                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Caset_UpdateAsignado")
                Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, CInt(item.Tag))
                Crea_Parametro(cmd, "@Id_Cliente_Asignado", SqlDbType.Int, Id_Cliente)
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "AC")
                EjecutarNonQueryT(cmd)

            Next

            tr.Commit()
        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_CasetAsignaCliente_Disponibles(ByVal lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_CasetAsignaCliente_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            lsv.Actualizar(cmd, "Id_Asignacion")
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_Caset_Read(ByVal Codigo_Barras As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@CodigoBarra", SqlDbType.VarChar, Codigo_Barras)
            Dim dt = EjecutaConsulta(cmd)

            If dt.Rows.Count > 0 Then Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        Finally
            cnn.Dispose()
            cmd.Dispose()
        End Try
    End Function

    Public Shared Function fn_kardex_Catalogo_LlenarLista(ByVal Lista As cp_Listview, ByVal Status As String) As Boolean

        Dim Cnn As SqlConnection = Nothing
        Dim Cmd As SqlCommand = Nothing
        Try
            'Aqui se llena el listview
            Cnn = Cn_Datos.Crea_ConexionSTD
            Cmd = Crea_Comando("Kardex_Caset_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Lista.Actualizar(Cmd, "Id_Caset")
        Catch ex As Exception
            TrataEx(ex)
            Return False
        Finally
            Cnn.Dispose()
            Cmd.Dispose()
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_Caset_Insert(ByVal CodigoBarra As String, ByVal Capacidad As Integer, ByVal Id_Cliente As Integer, ByVal Serie As String, ByVal Id_Color As Integer, ByVal SeguridadInterna As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Dim Caset_SISSA = CodigoBarra.Split("'")(0)
        Try

            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Create", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@CodigoBarra", SqlDbType.VarChar, CodigoBarra)
            Crea_Parametro(cmd, "@Capacidad", SqlDbType.Int, Capacidad)
            Crea_Parametro(cmd, "@Propio", SqlDbType.VarChar, If(Caset_SISSA = 1, "S", "N"))
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Serie", SqlDbType.VarChar, Serie)
            Crea_Parametro(cmd, "@Cliente_CodigoBarra", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Id_Color", SqlDbType.Int, Id_Color)
            Crea_Parametro(cmd, "@Seguridad_Interna", SqlDbType.VarChar, SeguridadInterna)



            'Dim id_Caset As Integer = EjecutarScalarT(cmd)


            'If id_Caset > 0 Then
            '    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Movimientos_Create")
            '    Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, id_Caset)
            '    Crea_Parametro(cmd, "@Id_Kardex_Cat_Movimiento", SqlDbType.Int, Id_Kardex_Cat_Movimiento)
            '    EjecutarNonQueryT(cmd)
            'End If

            EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            cnn.Dispose()
            cmd.Dispose()
            Return False
        End Try
    End Function

    Public Shared Function fn_kardex_Caset_update(ByVal Id_Caset As Integer, ByVal Capacidad As Integer, ByVal Serie As String, ByVal Id_Color As Integer) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Update", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, Id_Caset)
            Crea_Parametro(cmd, "@Capacidad", SqlDbType.Int, Capacidad)
            Crea_Parametro(cmd, "@Serie", SqlDbType.VarChar, Serie)
            Crea_Parametro(cmd, "@Id_Color", SqlDbType.Int, Id_Color)
            EjecutarNonQuery(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_kardex_Caset_Baja(ByVal Id_Caset As Integer, ByVal Status As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Baja", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, Id_Caset)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, If(Status = "ACTIVO", "A", "B"))
            EjecutarNonQuery(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_CasetAsignaCliente_Cancelar(ByVal Id_Asignacion As Integer, ByVal Id_Caset As Integer, ByVal Descripcion As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_CasetAsignaCliente_UpdateCancela", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Asignacion", SqlDbType.Int, Id_Asignacion)
            Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, Id_Caset)
            Crea_Parametro(cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Cancela", SqlDbType.VarChar, UsuarioN)
            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            EjecutarNonQuery(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_Caset_getSeguridad(ByVal lsv As cp_Listview) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_GetSegurdad", CommandType.StoredProcedure, cnn)
            lsv.Actualizar(cmd, "Id_Caset")
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function
#End Region



End Class
