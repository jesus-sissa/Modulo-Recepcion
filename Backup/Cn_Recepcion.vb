Imports System.Collections
Imports System.Windows.Forms
Imports Modulo_Recepcion.FuncionesGlobales
Imports Modulo_Recepcion.Cn_Datos
Imports System.Data.SqlClient

Public Class cn_Recepcion

#Region "Funciones Compartidas"

    'Public Shared Function fn_ValidarClave(ByVal clave As String, ByVal Parametro As String, ByVal Procedure As String) As Boolean
    '    'Aqui se actualiza un elemento 
    '    Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

    '    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedure, CommandType.StoredProcedure, Cnn)
    '    Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.VarChar, clave)

    '    Try

    '        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
    '        If Tbl.Rows.Count = 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If

    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return False
    '    End Try
    'End Function

    Public Shared Function fn_LlenarLista(ByVal Procedure As String, ByVal Indice As String, ByVal Lista As cp_Listview, _
                                          ByVal Sucursal As Boolean) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedure, CommandType.StoredProcedure, Cnn)

            If Sucursal Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            End If


            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, Indice)
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_LlenarListaD(ByVal Procedure As String, ByVal Indice As String, ByVal Lista As cp_Listview, ByVal Id_VentMat As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedure, CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, Indice, SqlDbType.Int, Id_VentMat)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, Indice)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Status(ByVal Id As Long, ByVal status As Char, ByVal Procedimiento As String, ByVal Campo As String, ByVal Sucursal As Boolean) As Boolean
        'Aqui se actualiza un pais
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        If Sucursal Then
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        End If
        Cn_Datos.Crea_Parametro(Cmd, Campo, SqlDbType.BigInt, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Cancela(ByVal Id As Integer, ByVal Procedimiento As String, ByVal Campo As String, ByVal Sucursal As Boolean, ByVal Usuario As Boolean) As Boolean
        'Aqui se actualiza un pais
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        If Sucursal Then
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        End If
        If Usuario = True Then
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
        End If
        Cn_Datos.Crea_Parametro(Cmd, Campo, SqlDbType.Int, Id)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_StatusD(ByVal Id As Integer, ByVal status As Char, ByVal Procedimiento As String, ByVal Campo As String, ByVal Usuario As Boolean) As Boolean
        'Aqui se actualiza un pais
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        Dim resulset As Integer = 0

        Cn_Datos.Crea_Parametro(Cmd, Campo, SqlDbType.Int, Id)

        If Usuario = True Then
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
        End If

        Try
            resulset = Cn_Datos.EjecutarScalar(Cmd)

            If resulset > 0 Then
                Return True
            Else
                Return False
            End If

        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarClave(ByVal clave As String, ByVal Parametro As String, ByVal Procedure As String) As Boolean
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedure, CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.VarChar, clave)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_LlenarLista(ByVal Procedure As String, ByVal Indice As String, ByVal Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedure, CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, Indice)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Status(ByVal Id As Integer, ByVal status As Char, ByVal Procedimiento As String, ByVal Campo As String) As Boolean
        'Aqui se actualiza un pais
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, Campo, SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ValidarDependencias(ByVal Id As Integer, ByVal Procedimiento As String, ByVal Parametro As String) As Boolean

        'Aqui se valida una dependencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.Int, Id)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ObtenValores(ByVal Id As Integer, ByVal Procedimiento As String, ByVal Parametro As String, ByVal Sucursal As Boolean) As Array
        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)

        If Not Parametro = "" Then
            Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.Int, Id)
        End If

        If Sucursal Then
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        End If

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                MsgBox("No existe el registro solicitado", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Return Tbl.Rows(0).ItemArray
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

    Public Shared Function fn_AlertasDestinos_Consultar(ByVal Clave_Alerta As String) As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasDestinos_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_Alerta)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_AlertasGeneradas_Guardar(ByVal Clave_AlertaTipo As String, ByVal Detalles As String, ByVal AlertasD As DataTable, ByVal EnviarMail As Boolean, ByVal Asunto As String, ByVal Adjunto As String, ByVal DetallesHTML As String) As Boolean
        Dim Id_Alerta As Integer = 0
        Dim cmd As SqlCommand
        Dim Dt_Destinos As DataTable
        Dim Encabezado As String = ""
        Dim Pie As String = ""

        Try
            'Obtener los Destinos
            Dt_Destinos = fn_AlertasDestinos_Consultar(Clave_AlertaTipo)
            If Dt_Destinos IsNot Nothing Then
                If Dt_Destinos.Rows.Count = 0 Then
                    MsgBox("No se encotnraron destinatarios para enviar la Alerta.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Return False
                End If
                If Adjunto <> "" Then
                    Detalles = Detalles & Chr(13) & Chr(13) & "(Ver archivo adjunto)"
                End If

                'Guardar la alerta para cada destino
                For Each Destino As DataRow In Dt_Destinos.Rows
                    cmd = Crea_Comando("Cat_AlertasGeneradas_CreateUna", CommandType.StoredProcedure, Crea_ConexionSTD())
                    Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
                    Crea_Parametro(cmd, "@Detalles", SqlDbType.VarChar, Detalles)
                    Crea_Parametro(cmd, "@Id_EmpleadoDestino", SqlDbType.Int, Destino("Id_Empleado"))
                    Crea_Parametro(cmd, "@Id_EmpleadoGenera", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_Genera", SqlDbType.VarChar, EstacioN)
                    Crea_Parametro(cmd, "@Tipo_Alerta", SqlDbType.Int, 1)
                    Id_Alerta = CInt(EjecutarScalar(cmd))
                    'Guardar el Detalle para cada alerta generada
                    If AlertasD IsNot Nothing Then
                        For Each dr As DataRow In AlertasD.Rows
                            cmd.Parameters.Clear()
                            cmd = Crea_Comando("Cat_AlertasGeneradasD_Create", CommandType.StoredProcedure, Crea_ConexionSTD())
                            Crea_Parametro(cmd, "@Id_Alerta", SqlDbType.Int, Id_Alerta)
                            Crea_Parametro(cmd, "@Id_Entidad", SqlDbType.Int, dr("Id"))
                            Crea_Parametro(cmd, "@Clave_Entidad", SqlDbType.VarChar, dr("Clave"))
                            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, dr("Nombre"))
                            EjecutarNonQuery(cmd)
                        Next
                    End If
                    If EnviarMail Then
                        Select Case Clave_AlertaTipo
                            Case "39"
                                Encabezado = "DIFERENCIA EN AUDITORIA DE CAJEROS"

                        End Select

                        Pie = "Agente de Servicios SIAC " & Now.Year.ToString

                        If DetallesHTML = "" Then
                            Cn_Mail.fn_Enviar_Mail(Destino("Mail"), Asunto, Detalles, Adjunto)
                        Else
                            DetallesHTML = Replace(DetallesHTML, "Encabezado", Encabezado)
                            DetallesHTML = Replace(DetallesHTML, "Pie", Pie)
                            Cn_Mail.fn_Enviar_MailHTML(Destino("Mail"), Asunto, DetallesHTML, Adjunto)
                        End If
                    End If
                Next
                Return True
            Else
                'No se encontraron destinos
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AlertasGeneradas_Validar() As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasGeneradas_Existe", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, "04")

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#Region "Recepcion Rutas Externas"

    Public Shared Function fn_ReRutasExternas_Monedas() As DataTable

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Monedas_GetTipoCambio", CommandType.StoredProcedure, Cnn)
        Try

            Dim Tbl As DataTable = EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                MsgBox("No existe el registro solicitado(Tipo de Cambio)", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Tbl.Columns(2).ReadOnly = False
                Tbl.Columns(3).ReadOnly = False
                Return Tbl
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function


    Public Shared Function fn_RecRutasExternas_Nuevo(ByVal NumeroRemision As Long, ByVal Envases As Integer, _
                                                     ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                     ByVal IdCia As Integer, ByVal BovedaID As Integer, ByVal ClienteP As Integer, _
                                                     ByVal CajaBancaria As Integer, ByVal dt As DataTable, ByVal lsv As ListView, ByVal Proceso As Boolean, ByVal Id_ClienteD As Integer, ByVal Id_ClienteP As Integer) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim lc_Transaccion As SqlTransaction
        Dim Cmd As SqlCommand
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem
        Dim Rutas As Integer = 0

        lc_Transaccion = crear_Trans(Cnn)
        'Insertar la Remision
        Cmd = Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_Create")
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
        Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
        Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
        Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
        Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, Importe)
        Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, IdCia)
        Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Cliente_Destino", SqlDbType.Int, Id_ClienteD)
        Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

        Try

            lc_identity = EjecutarScalarT(Cmd)
            'Insertar los importes por Moneda
            For Each lc_dr As DataRow In dt.Rows

                Cmd = Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")
                If CInt(lc_dr(2)) = 0 And CInt(lc_dr(3)) = 0 Then

                Else
                    Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                    Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                    Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CInt(lc_dr(2)))
                    Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CInt(lc_dr(3)))

                    EjecutarNonQueryT(Cmd)
                End If

            Next

            'Insertar los Envases
            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")
            Rutas = Cn_Datos.EjecutarScalarT(Cmd)

            'Insertar en Bo_Boveda
            Dim Tipo, TipoP, EntidadO, EntidadD As Integer

            If Proceso Then Tipo = 2 : TipoP = 1 Else Tipo = 3 : TipoP = 0
            If Proceso Then EntidadO = ClienteP : EntidadD = 0 Else EntidadO = CajaBancaria : EntidadD = CajaBancaria

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Boveda_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, TipoP)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, EntidadO)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, EntidadD)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Rutas)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True

    End Function

    Public Shared Function fn_RecRutasExternas_ObtenClienteDestino(ByVal Id_CajaBancaria As Integer) As DataRow

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Pro_CajasBancarias_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return dt.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function


#End Region

#Region "Recepcion Rutas Propias"

    Public Shared Function fn_ReRutasPropiasLlenaListaRemisiones(ByRef lsv As ListView, ByVal Indice As Integer) As Boolean
        fn_LlenarListaD("Tv_puntosRemisiones_GetD", "id_Punto", lsv, Indice)
    End Function

    Public Shared Function fn_ReRutasPropiasLlenaListaRemisionesDataT(ByVal Id_Punto As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Tv_puntosRemisiones_GetD", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "id_Punto", SqlDbType.Int, Id_Punto)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function




    Public Shared Function fn_Remision_Existe(ByVal Numero_Remision As Int64, ByVal Id_CiaProp As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Remisiones_Existe", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, Numero_Remision)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_CiaProp)
            Dim dt As DataTable
            dt = Cn_Datos.EjecutaConsulta(Cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_RecRutasPropiasLlenalistaPuntos(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Tv_puntos_get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)
            lsv.Actualizar(Cmd, "Id_Punto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_RecRutasPropiasLlenalistaCompVisitas(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("TV_Puntos_GetCV", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)
            lsv.Actualizar(Cmd, "ID_PUNTO")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_MonitoreoConsultaCV(ByVal Id_Punto As Long) As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_ComprobantesV_GetByPunto", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Punto", SqlDbType.BigInt, Id_Punto)
        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RecRutaspropiasValidaCV(ByVal Id_Punto As Long, ByVal Numero As Long, ByVal Hora As String) As Boolean
        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_ComprobantesV_StatusVB", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Punto", SqlDbType.BigInt, Id_Punto)
            Crea_Parametro(cmd, "@Numero", SqlDbType.BigInt, Numero)
            Crea_Parametro(cmd, "@Hora_ComprobanteV", SqlDbType.VarChar, Hora)
            Crea_Parametro(cmd, "@Usuario_ValidaBoveda", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_ValidaBoveda", SqlDbType.VarChar, EstacioN)
            EjecutarNonQuery(cmd)

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutaspropiasCVexiste(ByVal Numero As Long) As Boolean
        Dim dt As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_ComprobantesV_Validar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Numero", SqlDbType.BigInt, Numero)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            dt = EjecutaConsulta(cmd)
            If dt.Rows.Count > 0 Then
                'ya existe
                Return True
            Else
                'No existe
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasLlenalistaPuntosPendientes(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("TV_Puntos_GetPuntosPendientes", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)
            lsv.Actualizar(Cmd, "ID_PUNTO")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasLlenalistaPuntosTodos(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("TV_Puntos_GetCompVisitas", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)
            lsv.Actualizar(Cmd, "ID_PUNTO")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasLlenalistaPuntosResumen(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Tv_Puntos_GetResumen", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)
            lsv.Actualizar(Cmd, "Id_Punto")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasLlenalistaMateriales(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Mat_Ventas_GetIdProg", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)
            lsv.Actualizar(Cmd, "Id_MatVenta")
            If lsv.Columns.Count > 0 Then
                lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasMateriales(ByVal Matid As Integer, ByVal CantidadEnvases As Integer, ByVal RemisionID As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Ruta As Integer
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)
        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")
            Ruta = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Ventas_Status")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_MatVenta", SqlDbType.Int, Matid)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "RB")
            Cn_Datos.EjecutarNonQueryT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Boveda_Status")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, RemisionID)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    ''' <summary>
    ''' Regresa a Bóveda una Dotacion de Cajeros En Espera o Cancelada
    ''' </summary>
    ''' <param name="PuntocId"></param>
    ''' <param name="CantidadEnvases"></param>
    ''' <param name="RemisionID"></param>
    ''' <param name="DotacionID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function fn_RecRutasPropiasAtmsRegBoveda(ByVal PuntocId As Integer, ByVal CantidadEnvases As Integer, ByVal RemisionID As Integer, ByVal DotacionID As Integer, ByVal StatusActual As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)
        Try
            'Actualizo Puntos
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Puntos_StatusBoveda")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_PuntoC", SqlDbType.Int, PuntocId)
            Cn_Datos.Crea_Parametro(Cmd, "@Status_Boveda", SqlDbType.VarChar, "RB")
            Cn_Datos.EjecutarNonQueryT(Cmd)

            'Cancelar el Punto Cuando esté "En Espera"
            If StatusActual = "A" Then
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Puntos_StatusCancela")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_PuntoC", SqlDbType.Int, PuntocId)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            End If

            'Actualizo Boveda
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Boveda_Status")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, RemisionID)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_RecRutasPropiasAtmsValidar(ByVal PuntocId As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As New SqlClient.SqlCommand
        Try
            Cmd = Cn_Datos.Crea_Comando("Caj_Puntos_StatusBoveda", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_PuntoC", SqlDbType.Int, PuntocId)
            Cn_Datos.Crea_Parametro(Cmd, "@Status_Boveda", SqlDbType.VarChar, "RB")
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasAtmsFallasValidar(ByVal Id_Falla As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As New SqlClient.SqlCommand
        Try
            Cmd = Cn_Datos.Crea_Comando("Caj_Fallas_StatusBoveda", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Falla", SqlDbType.Int, Id_Falla)
            Cn_Datos.Crea_Parametro(Cmd, "@Status_Boveda", SqlDbType.VarChar, "RB")
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasAtmsOrigenGet(ByVal Id_PuntoC As Integer) As DataRow
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As New SqlClient.SqlCommand
        Dim dt As New DataTable
        Try
            Cmd = Cn_Datos.Crea_Comando("Bo_Boveda_DesOrigGetATMs", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_PuntoC", SqlDbType.Int, Id_PuntoC)
            dt = EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            End If
            Return Nothing
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasAtmsFallasOrigenGet(ByVal Id_Falla As Integer) As DataRow
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As New SqlClient.SqlCommand
        Dim dt As New DataTable
        Try
            Cmd = Cn_Datos.Crea_Comando("Caj_Fallas_OrigenGet", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Falla", SqlDbType.Int, Id_Falla)
            dt = EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            End If
            Return Nothing
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RecRutasPropias_LlenarRemision(ByVal lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_RemisionesD_GetId", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
        Try
            lsv.Actualizar(cmd, "Id_Moneda")
            If lsv.Columns.Count > 0 Then
                lsv.Columns(1).TextAlign = HorizontalAlignment.Right
                lsv.Columns(2).TextAlign = HorizontalAlignment.Right
                lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasLlenalistaAtms(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Caj_Puntos_GetRem", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)
            lsv.Actualizar(Cmd, "Id_PuntoC")

            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            If lsv.Columns.Count > 9 Then
                lsv.Columns(10).Width = 0
                lsv.Columns(11).Width = 0
                lsv.Columns(12).Width = 0
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasLlenalistaAtmsFallas(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Caj_Fallas_GetRem", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)
            lsv.Actualizar(Cmd, "Id_Falla")
            If lsv.Columns.Count > 0 Then
                lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasEnvases(ByVal Id_Remision As Long) As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Envases_Get2", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                'MsgBox("No existe el registro solicitado.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RecRutasValidaRD(ByVal ID_Punto As Integer) As DataRow
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("TV_PuntosRC_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@ID_Punto", SqlDbType.Int, ID_Punto)
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

    Public Shared Function fn_RecRutasRemisionesD(ByVal Numero_Remision As Long) As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_RemisionesD_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, Numero_Remision)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.BigInt, CiaId)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                MsgBox("No se encontraron los Importes por Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Tbl.Columns(2).ReadOnly = False
                Tbl.Columns(3).ReadOnly = False
                Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RecRutasRemisionesDById(ByVal Id_Remision As Long) As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_RemisionesD_GetId", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                MsgBox("No se encontraron los Importes por Moneda.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Tbl.Columns(2).ReadOnly = False
                Tbl.Columns(3).ReadOnly = False
                Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PuntosRemisiones_Regresar(ByVal Id_Remision As Long, ByVal Id_Punto As Long, ByVal Status As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Cmd = Cn_Datos.Crea_Comando("TV_PuntosRemisiones_Regresar", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.BigInt, Id_Punto)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Valida", SqlDbType.VarChar, "B")
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Cnn.Close()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropias_Update(ByVal Id_Remision As Integer, ByVal NumeroRemision As Long, _
                                                    ByVal Envases As Integer, ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                    ByVal Id_Punto As Integer, ByVal dt As DataTable, ByVal lsv As ListView, _
                                                    ByVal ActualizarRemision As Boolean, ByVal Id_CiaProp As Integer, ByVal Hora_Remision As String) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem
        Dim Rutas As Integer = 0
        Dim Cliente_Origen As Integer = 0
        Dim Cliente_Destino As Integer = 0
        Dim Id_ClienteP As Integer = 0
        Dim dt_PuntosOD As DataTable
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Cmd = Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_PuntosOrigenDestino_Get")
        Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Id_Punto)
        Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
        dt_PuntosOD = Cn_Datos.EjecutaConsultaT(Cmd)

        If dt_PuntosOD IsNot Nothing Then
            If dt_PuntosOD.Rows.Count > 0 Then
                Cliente_Origen = dt_PuntosOD.Rows(0)("Cliente_Origen")
                Cliente_Destino = dt_PuntosOD.Rows(0)("Cliente_Destino")
                Id_ClienteP = dt_PuntosOD.Rows(0)("Id_ClienteP")
            End If
        End If

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_PuntosD_Update")
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
        Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
        Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
        Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_CiaProp)
        Cn_Datos.Crea_Parametro(Cmd, "@Hora_Remision", SqlDbType.VarChar, Hora_Remision) 'varchar(5)
        Try
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)
            If ActualizarRemision = True Then
                'Actualizar el Numero de Remision
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Remisiones_UpdateNumero")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
                Cn_Datos.Crea_Parametro(Cmd, "@Cliente_Origen", SqlDbType.Int, Cliente_Origen)
                Cn_Datos.Crea_Parametro(Cmd, "@Cliente_Destino", SqlDbType.Int, Cliente_Destino)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            End If
            For Each lc_dr As DataRow In dt.Rows
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Envases_Delete")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "TV_PuntosRemisiones_ValidadoStatus")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Valida", SqlDbType.VarChar, "B")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.BigInt, Id_Punto)
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_RecRutasPropias_Create(ByVal NumeroRemision As Long, _
                                                   ByVal Envases As Integer, ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                   ByVal Id_Punto As Integer, ByVal dt As DataTable, ByVal Id_Cia As Integer, ByVal Id_CiaProp As Integer, ByVal Hora_Remision As String, ByVal lsv As ListView) As Boolean
        'Aquí se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem
        Dim Cliente_Origen As Integer = 0
        Dim Cliente_Destino As Integer = 0
        Dim Id_ClienteP As Integer = 0
        Dim dt_PuntosOD As DataTable

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        'Aquí se Consulta Cliente_Origen, Cliente_Destino e Id_ClienteP
        'Inicio Raul 18/Jun/2010
        Cmd = Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_PuntosOrigenDestino_Get")
        Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Id_Punto)
        Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
        dt_PuntosOD = Cn_Datos.EjecutaConsultaT(Cmd)

        If dt_PuntosOD IsNot Nothing Then
            If dt_PuntosOD.Rows.Count > 0 Then
                Cliente_Origen = dt_PuntosOD.Rows(0)("Cliente_Origen")
                Cliente_Destino = dt_PuntosOD.Rows(0)("Cliente_Destino")
                Id_ClienteP = dt_PuntosOD.Rows(0)("Id_ClienteP")
            End If
        End If
        'Fin Raul 18/Jun/2010
        'Guardar la Remisión

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Remisiones_Create")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
        Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
        Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
        Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, Importe)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CiaProp", SqlDbType.Int, Id_CiaProp)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Cliente_Origen", SqlDbType.Int, Cliente_Origen)
        Cn_Datos.Crea_Parametro(Cmd, "@Cliente_Destino", SqlDbType.Int, Cliente_Destino)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
        Cn_Datos.Crea_Parametro(Cmd, "@Hora_Remision", SqlDbType.VarChar, Hora_Remision) 'varchar(5)

        Try
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)
            For Each lc_dr As DataRow In dt.Rows
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RemisionesD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_PuntosRemisionesValidado_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Id_Punto)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Valida", SqlDbType.VarChar, "B")
            Cn_Datos.EjecutarNonQueryT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_Puntos_Update")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Id_Punto)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "RU")
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    'Funcion que Recalcula TV_Puntos y TV_Programacion 5sep2014
    Public Shared Function fn_Recalcular_TVPuntos_TVProgramacion(ByVal Id_Punto As Long) As Boolean
        Dim cmd As SqlClient.SqlCommand
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim tr As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Id_Programacion As Long = 0
        Try
            ' Recalcula Remisiones, envases e importe TV_Puntos 4sep2014
            cmd = Cn_Datos.Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "TV_Puntos_Recalcular")
            Cn_Datos.Crea_Parametro(cmd, "@Id_Punto", SqlDbType.Int, Id_Punto)
            Id_Programacion = Cn_Datos.EjecutarScalarT(cmd)

            'Recalcula Remisiones, envases e importe TV_Programacion 4sep2014
            cmd = Cn_Datos.Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "TV_Programacion_Recalcular")
            Cn_Datos.Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
            Cn_Datos.EjecutarNonQueryT(cmd)
            tr.Commit()
            Return True
        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_RecRutasPropias_Guardar(ByVal BovedaID As Integer, ByVal ID_Programacion As Integer, ByVal Lsv_Puntos As ListView) As Integer
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim Rutas As Integer = 0
        Dim Remisiones As DataRow
        Dim Dt_Remisiones As New DataTable
        Dim Dt_Valores As New DataTable
        Dim Ct As Integer = 0 'ComprobantesTraslado
        Dim Rm As Integer = 0 'Remisiones

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            'Sacar el Id de la Ruta
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Rutas_ProgramadasClave")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_Programacion", SqlDbType.Int, ID_Programacion)
            Rutas = Cn_Datos.EjecutarScalarT(Cmd)

            'Recorrer el lsv de puntos 
            For Each Elemento In Lsv_Puntos.Items
                Rm = 0
                'Consultar todas las Remisiones del Punto que se validaron por Bóveda (Recepcion)
                'Dejando a un lado los que se validaron por Morralla
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_puntosRemisiones_GetD")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Elemento.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")
                Dt_Remisiones = Cn_Datos.EjecutaConsultaT(Cmd)

                'Verificar con que Tipo, TipoP, Entidad_Origen y Entidad_Destino se Insertaran en Bo_Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_ClientesProceso_TvComprobar")
                Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, CInt(Elemento.SubItems(3).Text))
                Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, CInt(Elemento.SubItems(4).Text))
                Dt_Valores = Cn_Datos.EjecutaConsultaT(Cmd)

                If Dt_Valores.Rows.Count > 0 Then

                    If Elemento.SubItems(5).Text = "EN" Then
                        'tv puntos remisiones marcar RR
                        For Each Remisiones In Dt_Remisiones.Rows

                            If Remisiones(3).ToString = "MARCADO PARA REGRESAR" Then
                                'La Remisión no se entregó al destino Final, se tiene que regresar a Bóveda
                                'Si la Remisión viene con status R se actualiza a RR y se regresa a Bo_Boveda.Status='A'
                                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Boveda_Status")
                                Cn_Datos.Crea_Parametro(Cmd, "@ID_Remision", SqlDbType.BigInt, CInt(Remisiones(10).ToString))
                                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                                Cn_Datos.EjecutarNonQueryT(Cmd)

                                'tv puntos remisiones marcar RR
                                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "TV_PuntosRemisiones_StatusRR")
                                Cn_Datos.Crea_Parametro(Cmd, "@ID_Remision", SqlDbType.BigInt, CInt(Remisiones(10).ToString))
                                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
                                Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Valida", SqlDbType.VarChar, "B")
                                Cn_Datos.EjecutarNonQueryT(Cmd)

                                Ct += 1
                            End If
                        Next 'remisiones

                    End If

                    If Elemento.SubItems(5).Text = "RU" Then
                        For Each Remisiones In Dt_Remisiones.Rows
                            If Remisiones(3).ToString = "VALIDADO" Then

                                'Inserta En Bo_Boveda
                                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Boveda_Create")
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
                                Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Dt_Valores.Rows(0).Item("Tipo"))
                                Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, Dt_Valores.Rows(0).Item("Entidad_Origen"))
                                Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, Dt_Valores.Rows(0).Item("Entidad_Destino"))
                                Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, Dt_Valores.Rows(0).Item("TipoP"))
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
                                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, CLng(Remisiones(10).ToString))
                                Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Rutas)
                                Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, 0)
                                Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
                                Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@DotacionNom", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")
                                Cn_Datos.EjecutarNonQueryT(Cmd)

                                'Actualiza Remision. Dentro de este procedimiento tambien se le cambia el Status al Punto
                                'cuando ya no hay remisiones por afectar
                                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "TV_PuntosRemisiones_RB")
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.BigInt, Elemento.Tag)
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, CLng(Remisiones(10).ToString))
                                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "RB")

                                Cn_Datos.EjecutarNonQueryT(Cmd)
                                Ct += 1
                                Rm += 1
                            End If

                            'If Elemento.SubItems(1).Tag.ToString() = "1" Then
                            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Kardex_CasetUpdateRutaInicio")
                            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.BigInt, CInt(Elemento.SubItems(3).Text))
                            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Inicio", SqlDbType.VarChar, "N")
                            Cn_Datos.EjecutarNonQueryT(Cmd)
                            Elemento.SubItems(1).Tag = 0 ' asignarle un valor false, para que en la siguiente pasada no entre.
                            'End If

                        Next 'Remisiones

                    End If
                Else
                    MsgBox("El Cliente " & Elemento.Text & " no tiene servicio de proceso, el punto no será recibido.", MsgBoxStyle.Information, frm_MENU.Text)
                End If

            Next 'Puntos

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return 0

        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return Ct

    End Function

    Public Shared Function fn_RecRutasPropias_GuardarMov(ByVal ID_Programacion As Integer, ByVal Fecha As Date) As Boolean

        'Revisar que todos los puntos tengan su movimiento
        'y cuando no lo tengan se debe insertar uno
        Dim Cnn As SqlClient.SqlConnection
        Dim Cmd As SqlClient.SqlCommand
        Dim Dt_Remisiones As DataTable
        Dim Dt_Movimientos As DataTable
        Dim Dt_Datos As DataTable
        Dim Dt_RemisionesD As DataTable
        'Datos para el Movimiento
        Dim Id_Ruta As Integer = 0
        Dim Id_Movimiento As Integer = 0
        Dim Id_Cliente As Integer
        Dim Id_CS As Integer
        Dim Id_Precio As Integer
        Dim Id_CR As Integer
        Dim Id_EE As Integer
        Dim Id_KM As Integer
        Dim Cantidad_Remisiones As Integer
        Dim Cantidad_Envases As Integer
        Dim Envases_Exceso As Integer
        Dim Importe As Decimal
        Dim Importe_Efectivo As Decimal
        Dim Importe_Documentos As Decimal
        Dim Miles As Decimal
        Dim Dt_Puntos As DataTable
        Dim TipoTV As Byte

        Dim HayCR As Boolean
        Dim Cobra_Doctos As String
        Dim Redondeado As String
        Dim CantidadXunidad As Integer
        Dim MilesSinCosto As Integer

        Dim HayKM As Boolean
        Dim CantidadKM As Integer

        Dim Movimiento_Verificado As Integer

        Try
            Cnn = Cn_Datos.Crea_ConexionSTD
            'Sacar el Id de la Ruta
            Cmd = Cn_Datos.Crea_Comando("CAT_Rutas_ProgramadasClave", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@ID_Programacion", SqlDbType.Int, ID_Programacion)
            Id_Ruta = Cn_Datos.EjecutarScalar(Cmd)

            'Consultar todos los Puntos de la Ruta
            Cmd = Cn_Datos.Crea_Comando("Tv_Puntos_ReadTodos", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_Programacion)
            Dt_Puntos = Cn_Datos.EjecutaConsulta(Cmd)

            'Recorrer el dt_puntos 
            For Each Punto As DataRow In Dt_Puntos.Rows
                Cantidad_Envases = 0
                Cantidad_Remisiones = 0
                Importe_Efectivo = 0
                Importe_Documentos = 0
                Importe = 0
                Miles = 0
                Id_CS = 0
                Id_CR = 0
                Id_KM = 0
                Id_EE = 0
                Id_Precio = 0
                Id_Movimiento = 0
                Movimiento_Verificado = 0
                HayCR = False
                Cobra_Doctos = "N"
                Redondeado = "S"
                CantidadXunidad = 1000
                MilesSinCosto = 0
                HayKM = False
                CantidadKM = 0

                'Solo se afectarán los Estatus RB y EN
                If Punto("Status") <> "RB" And Punto("Status") <> "EN" Then Continue For

                'Cuando es un Despacho se brinca. Solo debe recalcular las Recolecciones
                If Punto("TipoTV") = 2 Then Continue For

0:              'Revisar si el Id_Punto ya existe en Cat_Movimientos. Solo se buscan puntos
                'RB porque En el proceso anterior (Grabar Servicio) todos los puntos RU 
                'se cambiaron a RB. Los que se quedaron RU es porque no se recibieron completos
                Cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_GetByPunto", CommandType.StoredProcedure, Cnn)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.VarChar, "T")
                Dt_Movimientos = Cn_Datos.EjecutaConsulta(Cmd)

                'Si no se pudo consultar se sale
                If Dt_Movimientos Is Nothing Then Continue For
                'Cuando ya existe un Movimiento se recalcula
                If Dt_Movimientos.Rows.Count > 0 Then
                    Id_Movimiento = Dt_Movimientos.Rows(0)("Id_Movimiento")
                    TipoTV = Dt_Movimientos.Rows(0)("TipoTV")
                    Movimiento_Verificado = Dt_Movimientos.Rows(0)("Mov_VerificadoRec")
                Else
                    Id_Movimiento = 0
                    Movimiento_Verificado = 0
                End If
                Dt_Movimientos = Nothing

                'Si el punto ya se verificó en una pasada Anterior, ya no se hace nada, se brinca al siguiente
                If Movimiento_Verificado = 1 Then Continue For

                Id_CS = Punto("Id_CS")
                Importe = Punto("Importe")
                'Cantidad_Envases = Punto("Cantidad_Envases")
                Cantidad_Remisiones = Punto("Cantidad_Remisiones")
                Id_Cliente = Punto("Cliente_Origen")

                'Con el Id_CS traer el Id_Precio, Id_CR, Id_EE, Id_KM
                Cmd = Cn_Datos.Crea_Comando("Cat_ClientesServicios_Read", CommandType.StoredProcedure, Cnn)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                Dt_Datos = Cn_Datos.EjecutaConsulta(Cmd)

                If Dt_Datos Is Nothing Then
                    GoTo SiguientePunto
                End If
                If Dt_Datos.Rows.Count = 0 Then
                    GoTo SiguientePunto
                End If
                Id_Precio = Dt_Datos.Rows(0)("Id_Precio")
                Id_CR = Dt_Datos.Rows(0)("Id_CR")
                Id_EE = Dt_Datos.Rows(0)("Id_EE")
                Id_KM = Dt_Datos.Rows(0)("Id_KM")
                Dt_Datos = Nothing

                'Consutlar los datos de CR para hacer los cálculos
                If Id_CR > 0 Then
                    Cmd = Cn_Datos.Crea_Comando("Cat_CuotaRiesgo_Read", CommandType.StoredProcedure, Cnn)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                    Dt_Datos = Cn_Datos.EjecutaConsulta(Cmd)
                    If Dt_Datos Is Nothing Then
                        GoTo SiguientePunto
                    End If
                    If Dt_Datos.Rows.Count > 0 Then
                        HayCR = True
                        Cobra_Doctos = Microsoft.VisualBasic.Left(Dt_Datos.Rows(0)("CobraDocumentos"), 1)
                        Redondeado = Microsoft.VisualBasic.Left(Dt_Datos.Rows(0)("Redondeado"), 1)
                        CantidadXunidad = Dt_Datos.Rows(0)("CantidadXunidad")
                        MilesSinCosto = Dt_Datos.Rows(0)("MilesScosto")
                    End If
                End If
                Dt_Datos = Nothing
                'Consutlar los datos de KM para Hacer los cálculos
                HayKM = False
                CantidadKM = 0
                If Id_KM > 0 Then
                    Cmd = Cn_Datos.Crea_Comando("Cat_Kilometros_Read", CommandType.StoredProcedure, Cnn)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                    Dt_Datos = Cn_Datos.EjecutaConsulta(Cmd)
                    If Dt_Datos Is Nothing Then
                        GoTo SiguientePunto
                    End If
                    If Dt_Datos.Rows.Count > 0 Then
                        'Si hay CR
                        HayKM = True
                        CantidadKM = Dt_Datos.Rows(0)("CantidadKM")
                    End If
                End If
                Dt_Datos = Nothing

                'Leer las Remisiones del punto para Insertar en Cat_MovimientosD
                Cmd = Cn_Datos.Crea_Comando("Tv_puntosRemisiones_GetD", CommandType.StoredProcedure, Cnn)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "T")
                Dt_Remisiones = Cn_Datos.EjecutaConsulta(Cmd)
                
                For Each Remision As DataRow In Dt_Remisiones.Rows
                    Cantidad_Envases += (Remision("Envases") + Remision("EnvasesSN"))
                    '1.- Recalcular la remision
                    Cmd = Cn_Datos.Crea_Comando("Cat_Remisiones_Recalcular", CommandType.StoredProcedure, Cnn)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                    Cn_Datos.EjecutarNonQuery(Cmd)

                    '2.- Consultar Importe Efectivo e Importe Documentos
                    Cmd = Cn_Datos.Crea_Comando("Cat_RemisionesD_GetTotales", CommandType.StoredProcedure, Cnn)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                    Dt_RemisionesD = Cn_Datos.EjecutaConsulta(Cmd)
                    If Dt_RemisionesD IsNot Nothing Then
                        If Dt_RemisionesD.Rows.Count > 0 Then
                            Importe_Efectivo += Dt_RemisionesD.Rows(0)("Efectivo")
                            Importe_Documentos += Dt_RemisionesD.Rows(0)("Documentos")
                        End If
                    End If
                    Dt_RemisionesD = Nothing
                Next

                'Hacer los calculos de los Miles
                If Cobra_Doctos = "S" Then Importe = Importe_Efectivo + Importe_Documentos Else Importe = Importe_Efectivo

                If Redondeado = "S" Then
                    If Importe Mod CantidadXunidad > 0 Then
                        If Importe Mod CantidadXunidad >= 999.5 Then
                            Miles = ((Importe \ CantidadXunidad)) - MilesSinCosto
                            'Le quité el "+1" porque cuando el resultado del mod es muy cercano a 1000
                            'se redondea automaticamente y el calculo de los miles sale mal
                            'sale 1 mil de mas
                        Else
                            Miles = ((Importe \ CantidadXunidad) + 1) - MilesSinCosto
                        End If
                    Else
                        Miles = (Importe / CantidadXunidad) - MilesSinCosto
                    End If
                Else
                    Miles = (Importe / CantidadXunidad) - MilesSinCosto
                End If
                If Miles < 0 Then Miles = 0

                'Se manda como Cero porque este campo ya no se usa
                Envases_Exceso = 0

                If Id_Movimiento = 0 Then
                    'Insertar en Cat_Movimientos
                    Cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_Create", CommandType.StoredProcedure, Cnn)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.VarChar, "R")
                    Cn_Datos.Crea_Parametro(Cmd, "@Hora", SqlDbType.VarChar, Left(Now.TimeOfDay.ToString, 5))
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Id_Ruta)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EE", SqlDbType.Int, Id_EE)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
                    Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
                    Cn_Datos.Crea_Parametro(Cmd, "@Miles", SqlDbType.Money, Miles)
                    Cn_Datos.Crea_Parametro(Cmd, "@Envases_Exceso", SqlDbType.Int, Envases_Exceso)
                    Cn_Datos.Crea_Parametro(Cmd, "@Kilometros", SqlDbType.Int, CantidadKM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Captura", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, 1)
                    Id_Movimiento = Cn_Datos.EjecutarScalar(Cmd)

                    'Insertar en Cat_MovimientosD
                    For Each Remision As DataRow In Dt_Remisiones.Rows
                        Cmd = Cn_Datos.Crea_Comando("Cat_MovimientosD_Create", CommandType.StoredProcedure, Cnn)
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                        Cn_Datos.EjecutarNonQuery(Cmd)
                    Next
                    Dt_Remisiones = Nothing
                Else
                    'Actualizar en Cat_Movimientos
                    Cmd = Cn_Datos.Crea_Comando("Cat_Movimientos_Update", CommandType.StoredProcedure, Cnn)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EE", SqlDbType.Int, Id_EE)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Id_Ruta)
                    Cn_Datos.Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)
                    Cn_Datos.Crea_Parametro(Cmd, "@Hora", SqlDbType.VarChar, Left(Now.TimeOfDay.ToString, 5))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
                    Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
                    Cn_Datos.Crea_Parametro(Cmd, "@Miles", SqlDbType.Money, Miles)
                    Cn_Datos.Crea_Parametro(Cmd, "@Envases_Exceso", SqlDbType.Int, Envases_Exceso)
                    Cn_Datos.Crea_Parametro(Cmd, "@Kilometros", SqlDbType.Int, CantidadKM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Captura", SqlDbType.VarChar, EstacioN)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.EjecutarNonQuery(Cmd)
                    'Borrar las Remisiones de Cat_MovimientosD

                    For Each Remision As DataRow In Dt_Remisiones.Rows
                        'Este procedimiento Primero checa, si ya existe ya no lo inserta
                        Cmd = Cn_Datos.Crea_Comando("Cat_MovimientosD_Create2", CommandType.StoredProcedure, Cnn)
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                        Cn_Datos.EjecutarNonQuery(Cmd)
                    Next
                    Dt_Remisiones = Nothing
                End If

                'Marcar el Punto como Mov_VerificadoRec=1 para que ya no se considere en las siguientes pasadas por esta función
                Cmd = Cn_Datos.Crea_Comando("TV_Puntos_UpdateRec", CommandType.StoredProcedure, Cnn)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                Cn_Datos.Crea_Parametro(Cmd, "@Mov_VerificadoRec", SqlDbType.Int, 1)
                Cn_Datos.EjecutarNonQuery(Cmd)

SiguientePunto:
            Next 'Puntos

            'Dt_Movimientos.Dispose()

        Catch ex As Exception
            'lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False

        End Try
        'lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_RecRutasPropiasRemanentesAtms(ByVal NumeroRemision As Long, ByVal ProgramacionID As Integer, _
                                                   ByVal Envases As Integer, ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                   ByVal Id_PuntoC As Integer, ByVal DotacionId As Integer, ByVal dt As DataTable, ByVal lsv As ListView, _
                                                   ByVal BovedaID As Integer, ByVal EntidadDestino As Integer, ByVal EntidadOrigen As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Rutas As Integer
        Dim RemisionID As Integer
        Dim Elemento As ListViewItem
        Dim CantidadEnvases As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        CantidadEnvases = Envases + EnvasesSN

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Remisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
            Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
            Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
            Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
            Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, Importe)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            RemisionID = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Rutas_ProgramadasClave")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_Programacion", SqlDbType.Int, ProgramacionID)
            Rutas = Cn_Datos.EjecutarScalarT(Cmd)


            For Each lc_dr As DataRow In dt.Rows

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RemisionesD_Create")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, RemisionID)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))

                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next


            For Each Elemento In lsv.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, RemisionID)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next

            'Actualizo Puntos
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Puntos_StatusBoveda")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_PuntoC", SqlDbType.Int, Id_PuntoC)
            Cn_Datos.Crea_Parametro(Cmd, "@Status_Boveda", SqlDbType.VarChar, "RB")
            Cn_Datos.EjecutarNonQueryT(Cmd)

            'Remision Retiro
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Puntos_RetiroUpdate")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_PuntoC", SqlDbType.Int, Id_PuntoC)
            Cn_Datos.Crea_Parametro(Cmd, "@Remision_Retiro", SqlDbType.Int, RemisionID)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Retiro", SqlDbType.Int, 1)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            'Esta parte se cambio y ahora se hara desde traslado y tv_Movil
            ''Actualizo Dotaciones de la remision que entregue
            'Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Dotaciones_Status")
            'Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, DotacionId)
            'Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "EN")
            'Cn_Datos.EjecutarNonQueryT(Cmd)

            'Inserto en Bo_Boveda la remision nueva
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Boveda_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, EntidadOrigen)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, EntidadDestino)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, RemisionID)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Rutas)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "S")
            Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")

            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True

    End Function

    Public Shared Function fn_RecRutasPropiasAtmsRemanentes_Update(ByVal Id_Remision As Integer, ByVal NumeroRemision As Long, _
                                                    ByVal Envases As Integer, ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                    ByVal Id_PuntoC As Integer, ByVal dt As DataTable, ByVal lsv As ListView, ByVal DotacionId As Integer, _
                                                    ByVal BovedaID As Integer, ByVal EntidadDestino As Integer, ByVal EntidadOrigen As Integer) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem
        Dim Rutas As Integer = 0

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        'Actualizar la Remision
        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_PuntosD_Update")
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
        Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
        Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
        Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)

        Try
            lc_identity = Cn_Datos.EjecutarNonQueryT(Cmd)
            'Actualizar el Detalle de la Remision
            For Each lc_dr As DataRow In dt.Rows
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            'Borrar los Envases
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Envases_Delete")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            'Insertar los Envases
            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            'Actualizo Caj_Puntos
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Puntos_StatusBoveda")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_PuntoC", SqlDbType.Int, Id_PuntoC)
            Cn_Datos.Crea_Parametro(Cmd, "@Status_Boveda", SqlDbType.VarChar, "RB")
            Cn_Datos.EjecutarNonQueryT(Cmd)

            'Remision Retiro
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Puntos_RetiroUpdate")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_PuntoC", SqlDbType.Int, Id_PuntoC)
            Cn_Datos.Crea_Parametro(Cmd, "@Remision_Retiro", SqlDbType.BigInt, Id_Remision)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Retiro", SqlDbType.Int, 1)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            'Inserto en boveda la remisión nueva
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Boveda_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, EntidadOrigen)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, EntidadDestino)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Rutas)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "S")
            Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")

            Cn_Datos.EjecutarNonQueryT(Cmd)


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True

    End Function

    Public Shared Function fn_RecRutasPropiasCustodiaAtmsFallas(ByVal NumeroRemision As Long, ByVal ProgramacionID As Integer, _
                                                   ByVal Envases As Integer, ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                   ByVal Id_Falla As Integer, ByVal dt As DataTable, ByVal lsv As ListView, _
                                                   ByVal BovedaID As Integer, ByVal EntidadDestino As Integer, ByVal EntidadOrigen As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Rutas As Integer
        Dim RemisionID As Integer
        Dim Elemento As ListViewItem
        Dim CantidadEnvases As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)
        CantidadEnvases = Envases + EnvasesSN
        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Remisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
            Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
            Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
            Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
            Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, Importe)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            RemisionID = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Rutas_ProgramadasClave")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_Programacion", SqlDbType.Int, ProgramacionID)
            Rutas = Cn_Datos.EjecutarScalarT(Cmd)

            For Each lc_dr As DataRow In dt.Rows
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RemisionesD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, RemisionID)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, RemisionID)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
            'Actualizo Puntos
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Fallas_StatusBoveda")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Falla", SqlDbType.Int, Id_Falla)
            Cn_Datos.Crea_Parametro(Cmd, "@Status_Boveda", SqlDbType.VarChar, "RB")
            Cn_Datos.EjecutarNonQueryT(Cmd)
            'Remision Retiro
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Fallas_RetiroUpdate")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Falla", SqlDbType.Int, Id_Falla)
            Cn_Datos.Crea_Parametro(Cmd, "@Remision_Retiro", SqlDbType.Int, RemisionID)
            Cn_Datos.EjecutarNonQueryT(Cmd)
            'Inserto en Bo_Boveda la remision nueva
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Boveda_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, EntidadOrigen)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, EntidadDestino)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, RemisionID)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Rutas)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "S")
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")

            Cn_Datos.EjecutarNonQueryT(Cmd)
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_RecRutasPropiasCustodiaAtmsFallas_Update(ByVal Id_Remision As Integer, ByVal NumeroRemision As Long, _
                                                    ByVal Envases As Integer, ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                    ByVal Id_Falla As Integer, ByVal dt As DataTable, ByVal lsv As ListView, _
                                                    ByVal BovedaID As Integer, ByVal EntidadDestino As Integer, ByVal EntidadOrigen As Integer) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem
        Dim Rutas As Integer = 0

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        'Actualizar la Remision Tv_PuntosD_Update es como si fuera Cat_Remisiones_Update
        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_PuntosD_Update")
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
        Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
        Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
        Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)

        Try
            lc_identity = Cn_Datos.EjecutarNonQueryT(Cmd)
            'Actualizar el Detalle de la Remision
            For Each lc_dr As DataRow In dt.Rows
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            'Borrar los Envases
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Envases_Delete")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            'Insertar los Envases
            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            'Actualizo Caj_Puntos
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Fallas_StatusBoveda")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Falla", SqlDbType.Int, Id_Falla)
            Cn_Datos.Crea_Parametro(Cmd, "@Status_Boveda", SqlDbType.VarChar, "RB")
            Cn_Datos.EjecutarNonQueryT(Cmd)

            'Remision Retiro
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Fallas_RetiroUpdate")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Falla", SqlDbType.Int, Id_Falla)
            Cn_Datos.Crea_Parametro(Cmd, "@Remision_Retiro", SqlDbType.BigInt, Id_Remision)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            'Inserto en boveda la remisión nueva
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Boveda_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, EntidadOrigen)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, EntidadDestino)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Rutas)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "S")
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")

            Cn_Datos.EjecutarNonQueryT(Cmd)


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True

    End Function

    Public Shared Function fn_RecRutasPropiasAtms_Update(ByVal Id_Remision As Integer, ByVal NumeroRemision As Long, _
                                                    ByVal Envases As Integer, ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                    ByVal Id_Punto As Integer, ByVal dt As DataTable, ByVal lsv As ListView) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem
        Dim Rutas As Integer = 0

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)
        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_PuntosD_Update")
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
        Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
        Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
        Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
        Try
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)
            For Each lc_dr As DataRow In dt.Rows
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Envases_Delete")
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "TV_PuntosRemisiones_ValidadoStatus")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Valida", SqlDbType.VarChar, "B")
            Cn_Datos.EjecutarNonQueryT(Cmd)
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_RecRutasGetPunto(ByVal Id_Remision As Integer) As String
        Dim dt As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("TV_PuntosRemisiones_RemisionGet", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, Id_Remision)

        Try

            dt = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count = 0 Then
                MsgBox("No existe el registro solicitado", MsgBoxStyle.Critical, frm_MENU.Text)
                Return Nothing
            Else
                Return dt.Rows()("").ToString
                'Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try


    End Function

    Public Shared Function fn_RecRutasCuadre(ByVal Id_Programacion As Integer, ByVal Fecha As Date) As Boolean
        'Aqui se crean los objetos
        Dim frm As New frm_Reporte
        Dim rpt As New rpt_CuadreRuta
        Dim Ds As New ds_Despacho

        'Aqui se llena el reporte
        If Not fn_RecRutasLogo(Ds.DatosSucursal) Then
            Return False
        End If

        Dim row As DataRow = fn_RecRutasEmpresa()

        If row Is Nothing Then Return False

        'Dim Txt_Empresa As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("Txt_Empresa")
        'Txt_Empresa.Text = row("Nombre")

        'Dim Txt_Direccion As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("Txt_Direccion")
        'Txt_Direccion.Text = row("Direccion")

        row = fn_RecRutasRuta(Id_Programacion)

        If row Is Nothing Then Return False

        Dim Txt_Ruta As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Ruta")
        Txt_Ruta.Text = row("Ruta")

        Dim Txt_Cajero As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Cajero")
        Txt_Cajero.Text = row("Cajero")


        Dim txt_Piniciales As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Piniciales")
        Dim txt_PTelefono As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_PTelefono")
        Dim txt_PDespachados As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_PDespachados")
        Dim txt_PTotal As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_PTotal")

        txt_Piniciales.Text = 0
        txt_PTelefono.Text = 0
        txt_PDespachados.Text = 0
        txt_PTotal.Text = 0

        Dim Tbl As DataTable = fn_RecRutasTipos(Id_Programacion)
        Dim PuntosTotal As Integer = 0

        For Each row In Tbl.Rows
            Select Case row("Tipo")
                Case 1
                    txt_Piniciales.Text = row("Puntos")
                Case 2
                    txt_PDespachados.Text = row("Puntos")
                Case 3
                    txt_PTelefono.Text = row("Puntos")
            End Select

            PuntosTotal += row("Puntos")
        Next

        txt_PTotal.Text = PuntosTotal

        Dim txt_Pendientes As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Pendientes")
        Dim txt_Recibidos As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Recibidos")
        Dim txt_Entregados As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Entregados")
        Dim txt_Trasbordados As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Trasbordados")
        Dim txt_Cancelados As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Cancelados")
        Dim txt_CompVisita As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_CompVisita")
        Dim txt_RecBov As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_RecBov")
        Dim txt_Regresado As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Regresado")
        Dim txt_Total As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Total")

        txt_Pendientes.Text = 0
        txt_Recibidos.Text = 0
        txt_Entregados.Text = 0
        txt_Trasbordados.Text = 0
        txt_Cancelados.Text = 0
        txt_CompVisita.Text = 0
        txt_RecBov.Text = 0
        txt_Regresado.Text = 0
        txt_Total.Text = 0
        PuntosTotal = 0

        Tbl = fn_RecRutasStatus(Id_Programacion)
        For Each row In Tbl.Rows
            Select Case row("Status")
                Case "A"
                    If txt_Pendientes.Text = "" Then txt_Pendientes.Text = 0
                    txt_Pendientes.Text += row("Puntos")
                Case "RU"
                    txt_Recibidos.Text = row("Puntos")
                Case "EN"
                    txt_Entregados.Text = row("Puntos")
                Case "TR"
                    txt_Trasbordados.Text = row("Puntos")
                Case "CA"
                    txt_Cancelados.Text = row("Puntos")
                Case "CV"
                    txt_CompVisita.Text = row("Puntos")
                Case "RB"
                    txt_RecBov.Text = row("Puntos")
                Case "RR"
                    txt_Regresado.Text = row("Puntos")
            End Select

            PuntosTotal += row("Puntos")
        Next

        txt_Total.Text = PuntosTotal

        fn_RecRutasGetCuadre(Ds.tbl_Cuadre, Id_Programacion)

        Dim txt_Fecha As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Fecha")
        txt_Fecha.Text = Fecha.ToShortDateString

        Dim txt_EPendientes As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section4.ReportObjects("txt_EPendientes")
        Dim txt_EValidados As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section4.ReportObjects("txt_EValidados")
        Dim txt_ERegresados As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section4.ReportObjects("txt_ERegresados")
        Dim txt_EBoveda As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section4.ReportObjects("txt_EBoveda")
        Dim txt_ERegresar As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section4.ReportObjects("txt_ERegresar")
        Dim txt_EEntregados As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section4.ReportObjects("txt_EEntregados")

        txt_EPendientes.Text = 0
        txt_EValidados.Text = 0
        txt_ERegresados.Text = 0
        txt_EBoveda.Text = 0
        txt_ERegresar.Text = 0
        txt_EEntregados.Text = 0

        Tbl = fn_RecRutasRemisiones(Id_Programacion)

        For Each row In Tbl.Rows
            Select Case row("Status")
                Case "A"
                    txt_EPendientes.Text = row("Remisiones")
                Case "R"
                    txt_ERegresar.Text = row("Remisiones")
                Case "V"
                    txt_EValidados.Text = row("Remisiones")
                Case "RB"
                    txt_EBoveda.Text = row("Remisiones")
                Case "RR"
                    txt_ERegresados.Text = row("Remisiones")
                Case "EN"
                    txt_EEntregados.Text = row("Remisiones")
            End Select


        Next

        'Aqui se despliega el reporte
        rpt.SetDataSource(Ds)
        frm.crv.ReportSource = rpt
        frm.ShowDialog()

        Return True
    End Function

    Public Shared Function fn_RecRutasRemisiones(ByVal Id_Programacion As Integer) As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("TV_Programacion_ReporteGetRemisiones", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RecRutasGetCuadre(ByRef Tabla As ds_Despacho.tbl_CuadreDataTable, ByVal Id_Programacion As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("TV_Programacion_ReporteGetCuadre", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)

        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasTipos(ByVal Id_Programacion As Integer) As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("TV_Programacion_ReporteGetTipoTV", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RecRutasStatus(ByVal Id_Programacion As Integer) As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("TV_Programacion_ReporteGetStatus", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)

        Try
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RecRutasRuta(ByVal Id_Programacion As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("TV_Programacion_ReporteGetHeader", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)

        Try
            Dim tbl As DataTable = EjecutaConsulta(cmd)

            If tbl.Rows.Count > 0 Then
                Return tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RecRutasEmpresa() As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            Dim tbl As DataTable = EjecutaConsulta(cmd)

            If tbl.Rows.Count > 0 Then
                Return tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RecRutasLogo(ByRef Tabla As ds_Despacho.DatosSucursalDataTable) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


#End Region

#Region "Recepcion de Custodias ATMs"

    Public Shared Function fn_RecepcionCustodiasATMs_Guardar(ByVal NumeroRemision As Long, ByVal Envases As Integer, _
                                                     ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                     ByVal IdCia As Integer, ByVal BovedaID As Integer, ByVal Cajero As Integer, _
                                                     ByVal CajaBancaria As Integer, ByVal dt As DataTable, ByVal lsv As ListView) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem
        Dim Rutas As Integer = 0

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_Create")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
        Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
        Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
        Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, Importe)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, IdCia)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)

        Try

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)


            For Each lc_dr As DataRow In dt.Rows

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")

                If CInt(lc_dr(2)) = 0 And CInt(lc_dr(3)) = 0 Then

                Else
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                    Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                    Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))

                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If

            Next


            For Each Elemento In lsv.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next


            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")

            Rutas = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Boveda_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, Cajero)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Rutas)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "S")
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")

            Cn_Datos.EjecutarNonQueryT(Cmd)


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True
    End Function

    Public Shared Function fn_MovIntCustodias_Guardar(ByVal NumeroRemision As Long, ByVal Envases As Integer, _
                                                     ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                     ByVal IdCia As Integer, ByVal BovedaID As Integer, ByVal Destino As Integer, _
                                                     ByVal Origen As Integer, ByVal dt As DataTable, ByVal lsv As ListView, ByVal Rutas As Integer) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Remisiones_Create")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
        Cn_Datos.Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
        Cn_Datos.Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, MonedaId)
        Cn_Datos.Crea_Parametro(Cmd, "@ImporteTotal", SqlDbType.Money, Importe)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, IdCia)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)

        Try

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)


            For Each lc_dr As DataRow In dt.Rows

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_RemisionesD_Create")

                If CInt(lc_dr(2)) = 0 And CInt(lc_dr(3)) = 0 Then

                Else
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                    Cn_Datos.Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                    Cn_Datos.Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))

                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If

            Next


            For Each Elemento In lsv.Items

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_Envases_Create")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)

                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Boveda_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, Origen)
            Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, Destino)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, lc_identity)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Rutas)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "N")
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")

            Cn_Datos.EjecutarNonQueryT(Cmd)


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True
    End Function

#End Region

#Region "Consulta Saldos"

    Public Shared Function fn_ConsultaSaldosLlenalista(ByVal lsv As cp_Listview, ByVal Tipo As Integer, Optional ByVal IDBoveda As Integer = 0, Optional ByVal Tipop As Integer = -1) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetSaldos", CommandType.StoredProcedure, Cnn)
            If IDBoveda <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, IDBoveda)
            End If
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
            If Tipop <> -1 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Tipop", SqlDbType.Int, Tipop)
            End If
            Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Bo")
            If lsv.Columns.Count > 0 Then
                lsv.Columns(2).TextAlign = HorizontalAlignment.Right
                lsv.Columns(5).TextAlign = HorizontalAlignment.Right
                lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            End If
         
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaMatSaldosLlenalista(ByVal lsv As cp_Listview, Optional ByVal Id_Boveda As Integer = 0) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_SaldosMatGet", CommandType.StoredProcedure, Cnn)
            If Id_Boveda <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
            End If
            Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Bo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Remision_Baja(ByVal lsv As cp_Listview) As Boolean
        Dim TotalBajas As Integer = 0
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tran As SqlTransaction = crear_Trans(cnn)
        Try
            Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "bo_boveda_StatusPorID")

            Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, 0)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
            For Each Elemento As ListViewItem In lsv.CheckedItems
                Cmd.Parameters("@Id_Bo").Value = Elemento.Tag
                If EjecutarNonQueryT(Cmd) > 0 Then TotalBajas += 1
            Next

            If lsv.CheckedItems.Count = TotalBajas Then
                tran.Commit()
                cnn.Close()
                Return True
            Else
                tran.Rollback()
                cnn.Close()
                Return False
            End If
        Catch ex As Exception
            tran.Rollback()
            cnn.Close()
            TrataEx(ex)
        End Try
    End Function

    Public Shared Function fn_ConsultaSaldo_ObtenerDatosRemision(ByVal Id_Boveda As Integer) As DataRow
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Bo_Boveda_Read", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, Id_Boveda)

            Dim dt As DataTable = EjecutaConsulta(Cmd)
            If dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return (dt.Rows(0))
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ConsultaSaldo_GuardarRemisionReemplazo(ByVal Id_RemisionAnterior As Integer, ByVal RemisionReemplazo As Long, ByVal Envases As Integer, _
                                                                     ByVal EnvasesSN As Integer, ByVal dt As DataTable, ByVal lsv As ListView, ByVal Id_Bo As Integer) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Trans As SqlTransaction
        Dim Cmd As SqlCommand
        Dim ID_NuevaRemision As Integer
        Dim Elemento As ListViewItem

        Trans = crear_Trans(Cnn)
        Try

            Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Remisiones_CreateReemplazo")

            'Insertar la Remisión de Reemplazo
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_RemisionAnterior)
            Crea_Parametro(Cmd, "@RemisionReemplazo", SqlDbType.BigInt, RemisionReemplazo)
            Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
            Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            ID_NuevaRemision = EjecutarScalarT(Cmd)

            'Insertar el Detalle de la Remisión de Reemplazo
            For Each lc_dr As DataRow In dt.Rows

                Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_RemisionesD_Create")

                Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, ID_NuevaRemision)
                Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))

                EjecutarNonQueryT(Cmd)

            Next

            'Insertar los Envases
            For Each Elemento In lsv.Items
                Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "CAT_Envases_Create")
                Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, ID_NuevaRemision)
                Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, CInt(Elemento.Tag))
                Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                EjecutarNonQueryT(Cmd)
            Next

            'Actualizar el Id_Remision en la tabla Cat_MovimientosD
            Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_MovimientosD_UpdateRemision")
            Crea_Parametro(Cmd, "@Id_RemisionAnterior", SqlDbType.Int, Id_RemisionAnterior)
            Crea_Parametro(Cmd, "@Id_RemisionReemplazo", SqlDbType.Int, ID_NuevaRemision)
            EjecutarNonQueryT(Cmd)

            'Actualizar el Id_Remision en la tabla Bo_Boveda
            Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Bo_Boveda_UpdateRemision")
            Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, Id_Bo)
            Crea_Parametro(Cmd, "@Id_RemisionReemplazo", SqlDbType.Int, ID_NuevaRemision)
            EjecutarNonQueryT(Cmd)

            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Asignar Fecha y Ruta a Servicios"

    Public Shared Function fn_Servicios_LlenarBovedas(ByVal lsv As cp_Listview, ByVal Boveda As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetTipo1", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, Boveda)
        Crea_Parametro(cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

        Try
            lsv.Actualizar(cmd, "Id_Bo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Servicios_LlenarBovedasEnvase(ByVal lsv As cp_Listview, ByVal Boveda As Integer) As DataTable
        Dim dt As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetTipo1Envase", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, Boveda)
        Crea_Parametro(cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

        Try
            dt = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Servicios_LlenarAtmsEnvase(ByVal lsv As cp_Listview, ByVal Boveda As Integer) As DataTable
        Dim dt As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetTipoATmServiciosEnvase", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, Boveda)
        Crea_Parametro(cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

        Try
            dt = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Servicios_LlenarAtms(ByVal lsv As cp_Listview, ByVal Boveda As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetTipoATmServicios", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, Boveda)
        Crea_Parametro(cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

        Try
            lsv.Actualizar(cmd, "Id_Bo")
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Servicios_Actualizar(ByVal lsv As cp_Listview, ByVal Tipo_Asigna As String, Optional ByVal Fecha_Salida As Date = Nothing, Optional ByVal Ruta_Salida As Integer = Nothing) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlClient.SqlCommand
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Try
            For Each Elemento As ListViewItem In lsv.CheckedItems
                'Asignar la Fecha y/o Ruta
                cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Bo_Boveda_FechaRuta")
                Crea_Parametro(cmd, "@Id_Bo", SqlDbType.Int, Elemento.Tag)
                If Not Fecha_Salida = Nothing Then Crea_Parametro(cmd, "@Fecha_Salida", SqlDbType.DateTime, Fecha_Salida)
                If Not Ruta_Salida = Nothing Then Crea_Parametro(cmd, "@Ruta_Salida", SqlDbType.Int, Ruta_Salida)
                EjecutarNonQueryT(cmd)

                'Guiardar la Bitacora de Cambios
                cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Bo_AsignaFechaRuta_Create")
                Crea_Parametro(cmd, "@Id_Bo", SqlDbType.Int, Elemento.Tag)
                Crea_Parametro(cmd, "@Tipo_Asigna", SqlDbType.VarChar, Tipo_Asigna)
                Crea_Parametro(cmd, "@Usuario_Asigna", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion_Asigna", SqlDbType.VarChar, EstacioN)
                Crea_Parametro(cmd, "@Fecha_Asignada", SqlDbType.Date, Fecha_Salida)
                Crea_Parametro(cmd, "@Ruta_Asignada", SqlDbType.Int, Ruta_Salida)
                EjecutarNonQueryT(cmd)
            Next
            Tr.Commit()
            cmd.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            cmd.Dispose()
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_Servicios_ActualizarTipos(ByVal lsv As cp_Listview, ByVal Tipo As Integer, ByVal TipoP As Integer, ByVal DotacionPro As Char, _
                                                        ByVal DotacionMor As Char, ByVal DotacionATM As Char, ByVal Material As Char, ByVal ConcentracionATM As Char, _
                                                        ByVal CustodiaATM As Char, ByVal DotacionNom As Char) As Boolean
        Dim cmd As SqlClient.SqlCommand
        Dim cnn As SqlClient.SqlConnection
        Dim Tr As SqlClient.SqlTransaction
        Try
            cnn = Crea_ConexionSTD()
            Tr = crear_Trans(cnn)
            For Each Elemento As ListViewItem In lsv.CheckedItems
                cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Bo_Boveda_UpdateTipos")
                Crea_Parametro(cmd, "@Id_Bo", SqlDbType.Int, Elemento.Tag)
                Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
                Crea_Parametro(cmd, "@TipoP", SqlDbType.Int, TipoP)
                Crea_Parametro(cmd, "@DotacionPro", SqlDbType.VarChar, DotacionPro)
                Crea_Parametro(cmd, "@DotacionMor", SqlDbType.VarChar, DotacionMor)
                Crea_Parametro(cmd, "@DotacionATM", SqlDbType.VarChar, DotacionATM)
                Crea_Parametro(cmd, "@Material", SqlDbType.VarChar, Material)
                Crea_Parametro(cmd, "@ConcentracionATM", SqlDbType.VarChar, ConcentracionATM)
                Crea_Parametro(cmd, "@CustodiaATM", SqlDbType.VarChar, CustodiaATM)
                Crea_Parametro(cmd, "@DotacionNom", SqlDbType.VarChar, DotacionNom)

                EjecutarNonQueryT(cmd)
            Next
            Tr.Commit()

            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Despacho Proveedores"

    Public Shared Function fn_DespachoProveedoresLlenalista(ByVal lsv As cp_Listview, ByVal Id_Cia As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetProceso", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Bo")
            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_DespachoProveedores_Create(ByVal lsv As cp_Listview, ByVal Id_Cia As Integer, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, ByVal Importet As Decimal, ByVal str_Cia As String) As Boolean

        'Aqui se inserta un nuevo registro

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Id_Despacho As Integer = 0
        Dim Elemento As ListViewItem
        Dim Id_Ruta As Integer = 0

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")

            Id_Ruta = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Despacho_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 2)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Id_Ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, CantidadRemisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Despacho", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, 0)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Despacho", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Despacho", SqlDbType.VarChar, BovedaTipo)
            Id_Despacho = Cn_Datos.EjecutarScalarT(Cmd)

            For Each Elemento In lsv.CheckedItems
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_DespachoD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(6).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, Id_Ruta)
                Cn_Datos.Crea_Parametro(Cmd, "@Nombre_Destino", SqlDbType.VarChar, Elemento.SubItems(2).Text)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        If Not fn_DespachoProveedores_MostrarReporte(Id_Despacho, str_Cia) Then
            'Reversa al despacho
            Cmd = Cn_Datos.Crea_Comando("Bo_Despacho_Reversa", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
            Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Tipo_Cancela", SqlDbType.Int, 1)

            Cn_Datos.EjecutarNonQuery(Cmd)
            Return False
        End If

        'Actualizar el Despacho (19/04/2012 JNR)
        'Se actualiza el campo Pendiente de S a N cuando el despacho se finaliza correctametne
        Cmd = Crea_Comando("Bo_Depacho_UpdatePendiente", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
        Crea_Parametro(Cmd, "@Pendiente", SqlDbType.VarChar, "N")
        EjecutarNonQuery(Cmd)

        Return True

    End Function

#End Region

#Region "Despacho Propias"

    Public Shared Function fn_DespachoPropiasLlenalista(ByVal lsv As cp_Listview, ByVal ruta As Integer, ByVal Fecha As Date) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetProcesoPropias", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Entrada", SqlDbType.VarChar, FuncionesGlobales.fn_Fecha102(Fecha.ToShortDateString))
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Bo")
            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_DespachoAtmsLlenalista(ByVal lsv As cp_Listview, ByVal ruta As Integer, ByVal Fecha As Date) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetProcesoAtm", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Salida", SqlDbType.DateTime, Fecha.ToShortDateString)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            'Aqui se Actualiza la lista
            With lsv
                .Actualizar(Cmd, "Id_Bo")
                .Columns(0).TextAlign = HorizontalAlignment.Right
                .Columns(4).TextAlign = HorizontalAlignment.Right
                .Columns(5).TextAlign = HorizontalAlignment.Right
                .Columns(6).TextAlign = HorizontalAlignment.Right
                .Columns(10).Width = 0
                .Columns(11).Width = 0
                .Columns(12).Width = 0
                .Columns(13).Width = 0
            End With
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Despacho_ValidaStatus(ByVal lsv As cp_Listview) As Boolean
        'Revisar si las Remisiones aún están disponibles
        Dim Cantidad_Disponibles As Integer = 0
        Dim dt As DataTable
        Dim Cnn As SqlClient.SqlConnection
        Dim Cmd As SqlClient.SqlCommand
        Try
            'Aqui se llena el listview
            Cnn = Cn_Datos.Crea_ConexionSTD
            Cmd = Cn_Datos.Crea_Comando("Bo_Boveda_Read", CommandType.StoredProcedure, Cnn)

            For Each Elemento As ListViewItem In lsv.CheckedItems
                Cmd.Parameters.Clear()
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, Elemento.Tag)
                dt = Cn_Datos.EjecutaConsulta(Cmd)
                If dt IsNot Nothing Then
                    If dt.Rows.Count > 0 Then
                        If dt.Rows(0)("Status") = "A" Then
                            Cantidad_Disponibles += 1
                        End If
                    End If
                End If
            Next
            If Cantidad_Disponibles = lsv.CheckedItems.Count Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Despacho_RecalcularEnvases(ByVal Id_Programacion As Long) As Boolean
        Dim Cnn As SqlClient.SqlConnection
        Dim Cmd As SqlClient.SqlCommand
        Try
            '5Sep2014  se cambio el procedure.. antes era Tv_Programacion_RecalcularEnvases
            Cnn = Cn_Datos.Crea_ConexionSTD
            Cmd = Cn_Datos.Crea_Comando("Tv_Programacion_Recalcular", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_DespachoPropias_Create(ByVal lsv As cp_Listview, ByVal Ruta As Integer, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, ByVal ImporteT As Decimal, ByVal str_Ruta As String, ByVal str_Fecha As String, ByVal Id_Programacion As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim ID_CS As Integer
        Dim Id_punto As Integer
        Dim H_Recoleccion As String
        Dim Id_Mov As Integer = 0
        Dim Cliente_Anterior As Integer = 0
        Dim Movimiento_Existente As Boolean = False
        Dim Id_Despacho As Integer = 0
        Dim lc_Remisiones As Integer = 0
        Dim lc_Envases As Integer = 0
        Dim Id_Servicio As Integer = 0
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)
        H_Recoleccion = Now.ToString("HH:mm") & "/" & Now.ToString("HH:mm")

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Despacho_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_Programacion)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, CantidadRemisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Despacho", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Despacho", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Despacho", SqlDbType.VarChar, BovedaTipo)

            'Se Obtiene el Id_Despacho
            Id_Despacho = Cn_Datos.EjecutarScalarT(Cmd)

            'Para cada Remisión se inserta un registro en Bo_DespachoD
            'Y en el mismo procedimiento se le actualizan los valores de salida 
            'de Bo_Boveda: Usuario, Fecha, Ruta y Status

            For Each Elemento In lsv.CheckedItems
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_despachoD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, Ruta)
                Cn_Datos.Crea_Parametro(Cmd, "@Nombre_Destino", SqlDbType.VarChar, Elemento.SubItems(2).Text)
                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next
            'Se finaliza la transacción del Despacho
            lc_Transaccion.Commit()
            Cnn.Close()

            'Mostrar el Reporte. Si no se puede imprimir se le da reversa a lo anterior
            If Not fn_DespachoPropias_MostrarReporte(Id_Despacho, str_Fecha, Id_Programacion, str_Ruta) Then
Cancelar:
                Cmd = Cn_Datos.Crea_Comando("Bo_Despacho_Reversa", CommandType.StoredProcedure, Crea_ConexionSTD)
                Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
                Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
                Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
                Crea_Parametro(Cmd, "@Tipo_Cancela", SqlDbType.Int, 1)
                Cn_Datos.EjecutarNonQuery(Cmd)
                Return False
            End If

            'Si la Impresión fué correcta se continua con la Inserción de los Puntos y los movimientos
            lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

            'Actualizar el Despacho (19/04/2012 JNR)
            'Se actualiza el campo Pendiente 
            Cmd = Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Depacho_UpdatePendiente")
            Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
            Crea_Parametro(Cmd, "@Pendiente", SqlDbType.VarChar, "N")
            EjecutarNonQueryT(Cmd)

            'Recorrer la lista para crear los Puntos y los Puntos Remisiones
            For Each Elemento In lsv.CheckedItems
                lc_Envases = Integer.Parse(Elemento.SubItems(4).Text) + Integer.Parse(Elemento.SubItems(5).Text)
                lc_Remisiones = 1 'Siempre es una porque se recorre la lista de una por una

                'Buscar el ID_CS que se insertará en Tv_Puntos
                'Cuando es una Dotación se busca el ID_CS que esté marcado como Entrega de Dotacion
                'Para cargarle el Movimiento al Cliente Destino

                'Cuando es una Custodia se le cargará el Movimiento al Cliente Origen utilizando el 
                'ID_CS que esté marcado como Servicio Predeterminado
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_BuscaId_CS")
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)
                ID_CS = Cn_Datos.EjecutarScalarT(Cmd)

                Id_Servicio = CInt(Elemento.SubItems(11).Text)

                'Insertar o Actualizar el Punto en caso de que ya exista
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_Puntos_Create")
                'Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_Puntos_CreateNew")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
                Cn_Datos.Crea_Parametro(Cmd, "@Cliente_Origen", SqlDbType.Int, Elemento.SubItems(8).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Cliente_Destino", SqlDbType.Int, Elemento.SubItems(9).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@H_Recoleccion", SqlDbType.VarChar, H_Recoleccion)
                Cn_Datos.Crea_Parametro(Cmd, "@H_Entrega", SqlDbType.VarChar, "")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, IIf(Id_Servicio > 0, Id_Servicio, ID_CS))
                Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, ImporteT)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, lc_Remisiones)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, lc_Envases)
                Cn_Datos.Crea_Parametro(Cmd, "@TipoTV", SqlDbType.Int, 2)
                Cn_Datos.Crea_Parametro(Cmd, "@Prioridad", SqlDbType.Int, 0)
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "RU")
                Id_punto = Cn_Datos.EjecutarScalarT(Cmd)

                'Insertar la Remision
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Tv_PuntosRemisiones_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Id_punto)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Valida", SqlDbType.VarChar, "B")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Actualizo datos de Salida en Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_BovedaStatusSalida_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoSalida", SqlDbType.Int, TurnoId)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Verifico si es Dotación
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Dotaciones_ExisteRemision")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)
                Dim Dt_Dotacion As DataTable = Cn_Datos.EjecutaConsultaT(Cmd)
                Dim Id_Dotacion As Integer = 0

                If Dt_Dotacion.Rows.Count > 0 Then
                    Id_Dotacion = Dt_Dotacion.Rows(0)("Id_Dotacion")
                    'Obtener los Datos para insertar el Movimiento
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Movimientos_GetDatosDotaciones")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, Elemento.Tag)
                    Dim Dt_Datos As Data.DataTable = EjecutaConsultaT(Cmd)
                    If Dt_Datos.Rows.Count > 0 Then
                        Dim Importe, Miles As Decimal
                        Dim EE As Integer = 0
                        Dim Km As Decimal = 0
                        'Hacer los calculos para los miles
                        Importe = Dt_Datos(0)("Efectivo") + Dt_Datos(0)("Documentos")

                        If Dt_Datos(0)("Id_CR") > 0 Then
                            If Dt_Datos(0)("Cobra_Documentos") = "N" Then Miles = Dt_Datos(0)("Efectivo") Else Miles = Importe

                            Miles = Miles / Dt_Datos(0)("CantidadXunidad")
                            If Dt_Datos(0)("Redondeado") = "S" And (Miles Mod 1) > 0 Then Miles = Math.Truncate(Miles) + 1

                            Miles = Miles - Dt_Datos(0)("Miles_Scosto")
                        End If

                        If Dt_Datos(0)("Id_EE") > 0 Then EE = Dt_Datos(0)("Envases_Scosto") - Dt_Datos(0)("Cantidad_Envases")
                        If Dt_Datos(0)("Id_KM") > 0 Then Km = Dt_Datos(0)("Cantidad_KM")

                        'Revisar si ya existe un Movimiento para este Cliente, Fecha y Ruta
                        Dim dt_Mov As DataTable
                        Movimiento_Existente = False
                        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Movimientos_Existe")
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Dt_Datos(0)("Id_Cliente"))
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Ruta)
                        Cn_Datos.Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, CDate(str_Fecha))
                        dt_Mov = Cn_Datos.EjecutaConsultaT(Cmd)
                        If dt_Mov.Rows.Count > 0 Then
                            Id_Mov = dt_Mov.Rows(0)("Id_Movimiento")
                            Movimiento_Existente = True
                        End If

                        'Si el cliente de esta remision es el mismo que el de la anterior
                        'Se anexa al mismo Movimiento. Esto es para cuando despacho mas de una Dotacion
                        'al Mismo Cliente que no se dupliquen los Movimientos

                        If (CInt(Dt_Datos(0)("Id_Cliente")) <> Cliente_Anterior) And Movimiento_Existente = False Then

                            'Insertar el Movimiento
                            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Movimientos_Create")
                            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.VarChar, "E")
                            Cn_Datos.Crea_Parametro(Cmd, "@Hora", SqlDbType.VarChar, Now.ToString("HH:mm"))
                            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Dt_Datos(0)("Id_Cliente"))
                            Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Ruta)
                            Cn_Datos.Crea_Parametro(Cmd, "@Id_Precio", SqlDbType.Int, Dt_Datos(0)("Id_Precio"))
                            Cn_Datos.Crea_Parametro(Cmd, "@Id_CR", SqlDbType.Int, Dt_Datos(0)("Id_CR"))
                            Cn_Datos.Crea_Parametro(Cmd, "@Id_EE", SqlDbType.Int, Dt_Datos(0)("Id_EE"))
                            Cn_Datos.Crea_Parametro(Cmd, "@Id_KM", SqlDbType.Int, Dt_Datos(0)("Id_KM"))
                            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, Dt_Datos(0)("Cantidad_Remisiones"))
                            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, Dt_Datos(0)("Cantidad_Envases"))
                            Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
                            Cn_Datos.Crea_Parametro(Cmd, "@Miles", SqlDbType.Money, Miles)
                            Cn_Datos.Crea_Parametro(Cmd, "@Envases_Exceso", SqlDbType.Int, EE)
                            Cn_Datos.Crea_Parametro(Cmd, "@Kilometros", SqlDbType.Int, Km)
                            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                            Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Id_punto)
                            Id_Mov = EjecutarScalarT(Cmd)
                        End If

                        'Insertar MovimientosD
                        Cmd = Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_MovimientosD_Create")
                        Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Mov)
                        Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)
                        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                        EjecutarNonQueryT(Cmd)
                        Cliente_Anterior = Dt_Datos(0)("Id_Cliente")
                    End If
                    'Actualizar las Dotaciones
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Dotaciones_Status")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, Id_Dotacion)
                    Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "DE")
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If
            Next
            
        Catch ex As Exception
            If lc_Transaccion.Connection Is Nothing Then
                MsgBox("Ha ocurrido un error al intentar desplegar el reporte, se cancelara el Despacho.", MsgBoxStyle.Critical)
                GoTo Cancelar
            Else
                lc_Transaccion.Rollback()
            End If
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_DespachoAtms_Create(ByVal lsv As cp_Listview, ByVal Ruta As Integer, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, ByVal ImporteT As Decimal, ByVal str_Fecha As String, ByVal str_Ruta As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim ID_Programacion As Integer
        Dim Id_Despacho As Integer = 0
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            'Obtener el Id_Programacion
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "TV_Programacion_GetIDPrograma")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha", SqlDbType.DateTime, Now.ToShortDateString)
            ID_Programacion = Cn_Datos.EjecutarScalarT(Cmd)

            'Insertar en Bo_Despacho
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Despacho_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, CantidadRemisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Despacho", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Despacho", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_Programacion)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Despacho", SqlDbType.VarChar, BovedaTipo)
            Id_Despacho = Cn_Datos.EjecutarScalarT(Cmd)

            'Insertar en Bo_DespachoD
            Debug.Print(Now.TimeOfDay.ToString)
            For Each Elemento In lsv.CheckedItems
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_despachoD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(8).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, Ruta)
                Cn_Datos.Crea_Parametro(Cmd, "@Nombre_Destino", SqlDbType.VarChar, Elemento.SubItems(2).Text)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
            'Debug.Print(Now.TimeOfDay.ToString)
            'Se finaliza la transaccion para que no se quede abierta mientras 
            'el reporte está en pantalla
            lc_Transaccion.Commit()
            Cnn.Close()

            'Imprimir el Reporte
            If Not fn_DespachoPropias_MostrarReporte(Id_Despacho, str_Fecha, ID_Programacion, str_Ruta) Then
Cancelar:
                Cmd = Cn_Datos.Crea_Comando("Bo_Despacho_Reversa", CommandType.StoredProcedure, Crea_ConexionSTD)
                Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
                Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
                Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
                Crea_Parametro(Cmd, "@Tipo_Cancela", SqlDbType.Int, 1)
                Cn_Datos.EjecutarNonQuery(Cmd)
                Return False
            End If

            lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

            'Actualizar el Despacho (19/04/2012 JNR)
            'Se actualiza el campo Pendiente 
            Cmd = Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Depacho_UpdatePendiente")
            Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
            Crea_Parametro(Cmd, "@Pendiente", SqlDbType.VarChar, "N")
            EjecutarNonQueryT(Cmd)

            For Each Elemento In lsv.CheckedItems
                'Insertar en Caj_Puntos
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Puntos_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_Programacion)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Cajero", SqlDbType.VarChar, Elemento.SubItems(12).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(8).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@H_Entrega", SqlDbType.VarChar, Elemento.SubItems(11).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Prioridad", SqlDbType.Int, 0)
                Cn_Datos.Crea_Parametro(Cmd, "@Status_Boveda", SqlDbType.VarChar, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Actualizo Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_BovedaStatusSalida_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(8).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoSalida", SqlDbType.Int, TurnoId)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                ''Actualizo Dotaciones
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Dotaciones_Status")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Dotacion", SqlDbType.Int, Elemento.SubItems(13).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "DE")
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

        Catch ex As Exception
            If lc_Transaccion.Connection Is Nothing Then
                MsgBox("Ha ocurrido un error al intentar desplegar el reporte, se cancelara el despacho", MsgBoxStyle.Critical)
                GoTo Cancelar
            Else
                lc_Transaccion.Rollback()
            End If

            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        My.Settings.Id_Despacho = 0
        My.Settings.Save()
        Cnn.Close()

        Return True

    End Function

    Public Shared Function fn_DespachoMateriales_Create(ByVal lsv As cp_Listview, ByVal Ruta As Integer, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, ByVal ImporteT As Decimal, ByVal str_Fecha As String, ByVal str_Ruta As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem
        Dim ID_Programacion As Integer
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        'Aqui se crea un registro en bo_despacho
        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "TV_Programacion_GetIDPrograma")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha", SqlDbType.DateTime, Now.ToShortDateString)
            ID_Programacion = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Despacho_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, CiaId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, CantidadRemisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Despacho", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Despacho", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_Programacion)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Despacho", SqlDbType.VarChar, BovedaTipo)
            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

            For Each Elemento In lsv.CheckedItems
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_despachoD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, lc_identity)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(6).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, Ruta)
                Cn_Datos.Crea_Parametro(Cmd, "@Nombre_Destino", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next

            lc_Transaccion.Commit()
            If Not fn_DespachoPropias_MostrarReporte(lc_identity, str_Fecha, ID_Programacion, str_Ruta) Then
Cancelar:
                Cmd = Cn_Datos.Crea_Comando("Bo_Despacho_Reversa", CommandType.StoredProcedure, Crea_ConexionSTD)
                Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, lc_identity)
                Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
                Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
                Cn_Datos.EjecutarNonQuery(Cmd)
                Return False
            End If
            Cnn.Close()
            lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

            For Each Elemento In lsv.CheckedItems

                'se actualiza mat_ventas
                'Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Ventas_StatusEnRuta")
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Ventas_StatusEnRutaNew")
                'Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(6).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(6).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_Programacion)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Actualizo Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_BovedaStatusSalida_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(6).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoSalida", SqlDbType.Int, TurnoId)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

        Catch ex As Exception
            If lc_Transaccion.Connection Is Nothing Then
                MsgBox("Ha ocurrido un error al intentar desplegar el reporte, se cancelara el despacho", MsgBoxStyle.Critical)
                GoTo Cancelar
            Else
                lc_Transaccion.Rollback()
            End If
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True

    End Function

    Public Shared Function fn_DespachoPropias_Pendientes(ByVal Desde As Date, ByVal Hasta As Date, ByVal Tipo As Integer) As Boolean
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Bo_Despacho_GetPendientes", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@FDesde", SqlDbType.DateTime, Desde)
            Crea_Parametro(Cmd, "@FHasta", SqlDbType.DateTime, Hasta)
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)

            Dim dt As DataTable = EjecutaConsulta(Cmd)
            Return dt.Rows.Count > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Reporte de Despacho"

    Public Shared Function fn_DespachoPropias_Logo(ByRef Tabla As ds_Despacho.DatosSucursalDataTable) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DespachoPropias_Reporte(ByRef Tabla As ds_Despacho.Tbl_DespachoDataTable, ByVal Id_Despacho As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Despacho_Reporte", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)

        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DespachoPropias_GetUnidad(ByVal Id_Programacion As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("TV_Programacion_ReporteGetDesp", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)

        Try
            Dim tbl As DataTable = EjecutaConsulta(cmd)

            If tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return tbl.Rows(0)
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_DespachoPropias_Totales(ByRef Tot As ds_Despacho.Tbl_TotalesDataTable, ByVal Id_Despacho As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_DenominacionesD_ReporteTotal", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
        Dim queesundim As String = ""
        Try
            cmd.Connection.Open()
            Tot.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DespachoProveedores_MostrarReporte(ByVal Id_Despacho As Integer, ByVal str_Cia As String) As Boolean
        Dim frm As New frm_Reporte
        Dim rpt As New rpt_DespachoProvNuevo
        Dim ds As New ds_Despacho

        fn_DespachoPropias_Logo(ds.DatosSucursal)
        fn_DespachoPropias_Reporte(ds.Tbl_Despacho, Id_Despacho)
        fn_DespachoPropias_Totales(ds.Tbl_Totales, Id_Despacho)

        'Aqui se manipulan los elementos del reporte
        '-------------------------------------------
        Dim txt_Ruta As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Cia")
        Dim txt_Recibe As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Recibe")
        Dim txt_Entrego As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_Entrego")
        txt_Ruta.Text = str_Cia
        txt_Entrego.Text = UsuarioN
        txt_Recibe.Text = str_Cia
        '------------------------------------------
        '-------------------------------------------
        rpt.SetDataSource(ds)
        rpt.Subreports("rpt_Totales").SetDataSource(ds)
        frm.crv.ReportSource = rpt

        Return frm.ShowDialog() = DialogResult.Yes
    End Function

    Public Shared Function fn_DespachoPropias_MostrarReporte(ByVal Id_Despacho As Integer, ByVal str_Fecha As String, ByVal Id_Programacion As Integer, ByVal str_Ruta As String) As Boolean
        'Aqui se imprime el reporte
        Dim frm As New frm_Reporte
        Dim rpt As New rpt_DespachoNuevo
        Dim ds As New ds_Despacho
        Dim Row As DataRow = fn_DespachoPropias_GetUnidad(Id_Programacion)
        Dim rptLista As New ListaDespacho

        fn_DespachoPropias_Logo(ds.DatosSucursal)
        fn_DespachoPropias_Reporte(ds.Tbl_Despacho, Id_Despacho)
        fn_DespachoPropias_Totales(ds.Tbl_Totales, Id_Despacho)
        fn_DespachoListaE(ds.tbl_ListaD, Id_Despacho)
        rpt.SetDataSource(ds)

        'Aqui se manipulan los elementos del reporte
        '-------------------------------------------

        '------------------------------------------
        Dim txt_Fecha As CrystalDecisions.CrystalReports.Engine.TextObject = rptLista.Section1.ReportObjects("txt_Fecha")
        Dim txt_Ruta As CrystalDecisions.CrystalReports.Engine.TextObject = rptLista.Section1.ReportObjects("txt_Ruta")
        Dim txt_Unidad As CrystalDecisions.CrystalReports.Engine.TextObject = rptLista.Section1.ReportObjects("txt_Unidad")
        Dim txt_Entrego As CrystalDecisions.CrystalReports.Engine.TextObject = rptLista.Section1.ReportObjects("entrega")
        Dim txt_Recibe As CrystalDecisions.CrystalReports.Engine.TextObject = rptLista.Section1.ReportObjects("recive")

        txt_Fecha.Text = str_Fecha
        txt_Ruta.Text = str_Ruta
        txt_Unidad.Text = Row("Descripcion")
        txt_Entrego.Text = UsuarioN
        txt_Recibe.Text = Row("Nombre")
        frm.crv.ReportSource = rptLista
        rptLista.SetDataSource(ds)
        If frm.ShowDialog() = DialogResult.No Then
            Return False
        End If        
        '-------------------------------------------

        txt_Fecha = rpt.Section1.ReportObjects("txt_Fecha")
        txt_Ruta = rpt.Section1.ReportObjects("txt_Ruta")
        txt_Unidad = rpt.Section1.ReportObjects("txt_Unidad")
        txt_Entrego = rpt.Section1.ReportObjects("txt_Entrego")
        txt_Recibe = rpt.Section1.ReportObjects("txt_Recibe")

        txt_Fecha.Text = str_Fecha
        txt_Ruta.Text = str_Ruta
        txt_Unidad.Text = Row("Descripcion")
        txt_Entrego.Text = UsuarioN
        txt_Recibe.Text = Row("Nombre")

   

        rpt.Subreports("rpt_Totales").SetDataSource(ds)
        frm.crv.ReportSource = rpt
        SegundosDesconexion = 0
        ''frm.ShowDialog()
        '
       
        '
        Return frm.ShowDialog() = DialogResult.Yes

        SegundosDesconexion = 0
        ''Lista remisiones

    End Function

#End Region

#Region "Cambiar Número de Remisión"

    Public Shared Function fn_RemisionRead(ByVal Id_Remision As Long) As DataTable
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Remisiones_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
            'Aqui se Actualiza la lista
            Return Cn_Datos.EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RemisionReadByIdBo(ByVal Id_Bo As Long) As DataTable
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Remisiones_ReadByIdBo", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.BigInt, Id_Bo)
            'Aqui se Actualiza la lista
            Return Cn_Datos.EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RemisionUpdateNumero(ByVal Id_Remision As Long, ByVal NuevoNumero As Long, ByVal Observaciones As String) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Remisiones_UpdateNumero", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NuevoNumero)
            Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            'Aqui se Actualiza la lista
            Return Cn_Datos.EjecutarNonQuery(Cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Asignar A Proceso -> 24/05/2014"

    Public Shared Function fn_AsignarProcesoLlenalista(ByVal lsv As cp_Listview, ByVal CajaBancaria As Integer, ByVal Cia As Integer, ByVal DeptoRegistro As Char) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetAsignarProceso", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Cia)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, DeptoRegistro)

            lsv.Actualizar(Cmd, "Id_Bo")
            lsv.Columns(9).Width = 0
            lsv.Columns(10).Width = 0
            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AsignarProcesoRetenidosLlenalista(ByVal lsv As cp_Listview, ByVal CajaBancaria As Integer, ByVal Cia As Integer, ByVal DeptoRegistro As Char) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetAsignarProceso", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Cia)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, DeptoRegistro) 'new 24/05/2014

            lsv.Actualizar(Cmd, "Id_Bo")
            lsv.Columns(9).Width = 0
            lsv.Columns(10).Width = 0
            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_AsignarProceso_Guardar(ByVal lsv As ListView, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, Optional ByVal TipoLote As Integer = 1) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim LotesID As Integer
        Dim Dt_Remisiones As New DataTable
        Dim Rutas As Integer
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")
            Rutas = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, TipoLote) '--?
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, CantidadRemisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            LotesID = Cn_Datos.EjecutarScalarT(Cmd)

            For Each Elemento In lsv.CheckedItems

                'Insertar Detalle
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisionesD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_lote", SqlDbType.Int, LotesID)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(6).Text)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Actualizo Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_BovedaStatusSalida_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(6).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoSalida", SqlDbType.Int, TurnoId)
                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False

        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True
    End Function

    Public Shared Function fn_AsignarProcesoLlenalistaEnvase(ByVal lsv As cp_Listview, ByVal CajaBancaria As Integer, ByVal Cia As Integer, ByVal DeptoRegistro As Char) As DataTable
        Try
            Dim dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetAsignarProcesoEnvases", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Cia)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, DeptoRegistro)

            dt = EjecutaConsulta(Cmd)
            Return dt

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_AsignarProceso_ValidaStatus(ByVal lsv As ListView) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim Dt_Remisiones As New DataTable  'nueva funcion 9/julio/2012

        Try

            For Each Elemento In lsv.CheckedItems
                'Actualizo Boveda
                Cmd = Cn_Datos.Crea_Comando("Bo_Boveda_Read", CommandType.StoredProcedure, Cnn)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_bo", SqlDbType.Int, Elemento.Tag)
                Dt_Remisiones = Cn_Datos.EjecutaConsulta(Cmd)
                If Dt_Remisiones.Rows.Count > 0 Then
                    If Dt_Remisiones.Rows(0)("Status") <> "A" Then
                        Return False
                    End If
                End If
            Next

        Catch ex As Exception

            TrataEx(ex)
            Return False

        End Try

        Return True

    End Function

    Public Shared Function fn_AsignarProceso_Guardar_Nuevo(ByVal lsv As ListView, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, ByVal Destino As Char) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim Dt_Remisiones As New DataTable
        'Dim Rutas As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            'Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")
            'Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            'Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            'Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")
            'Rutas = Cn_Datos.EjecutarScalarT(Cmd)

            For Each Elemento In lsv.CheckedItems

                'Insertar Detalle
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_LotesRecProceso_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Turno_boveda", SqlDbType.Int, TurnoId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(6).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Envia", SqlDbType.VarChar, EstacioN)
                Cn_Datos.Crea_Parametro(Cmd, "@Destino", SqlDbType.VarChar, Destino)
                Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, 0)
                Cn_Datos.EjecutarScalarT(Cmd)

                'Actualizo Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_BovedaStatusSalida_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(6).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoSalida", SqlDbType.Int, TurnoId)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_AsignarMorralla_Guardar(ByVal lsv As ListView) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim dt As DataTable
        Dim Id_Boveda As Integer = 0

        'Obtener la Bóveda de Morralla
        Cmd = Cn_Datos.Crea_Comando("Cat_Bovedas_ComboGetMorralla", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        dt = Cn_Datos.EjecutaConsulta(Cmd)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                '7	0004	BOVEDA MORRALLA
                Id_Boveda = dt.Rows(0)("Id_Boveda")
            End If
        End If
        Cmd.Parameters.Clear()
        Cmd = Nothing
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)
        Try
            For Each Elemento In lsv.CheckedItems
                'Actualizo Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_BovedaDptoRegistro_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, Elemento.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
                Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "M")
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_AsignarDevolucion_Guardar(ByVal lsv As ListView, ByVal Observaciones As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim Tipo As Integer = 2, TipoP As Integer = 4
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)
        Try
            For Each Elemento In lsv.CheckedItems
                Tipo = 2 : TipoP = 4
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_BovedaTipoTipoP_Update")
                If Elemento.SubItems(9).Text = CiaId Then
                    Tipo = 1 : TipoP = 0
                    ' si entro por RutaPropia
                    Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, Elemento.SubItems(10).Text) 'EntidadOrigen
                    Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, Elemento.SubItems(10).Text)
                End If
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, Elemento.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
                Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, TipoP)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cn_Login.fn_Log_Create("MARCAR PARA DEVOLUCION AL CLIENTE. REMISION: " & Elemento.Text & " CLIENTE: " & Elemento.SubItems(1).Text)
                FuncionesGlobales.fn_GuardaBitacora(31, "REMISION: " & Elemento.Text.Trim & " CLIENTE: " & Elemento.SubItems(1).Text.Trim & " OBSERVACIONES: " & Observaciones, CInt(Elemento.SubItems(6).Text))
            Next
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

#End Region

#Region "Devolucion de Resguardo"

    Public Shared Function fn_DevolucionResguardoLlenalista(ByVal lsv As cp_Listview, ByVal CajaBancaria As Integer, ByVal TipoP As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetDevolucionResguardo", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, TipoP)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)
            With lsv
                .Actualizar(Cmd, "Id_Bo")
                .Columns(0).TextAlign = HorizontalAlignment.Right
                .Columns(3).TextAlign = HorizontalAlignment.Right
                .Columns(4).TextAlign = HorizontalAlignment.Right
                .Columns(5).TextAlign = HorizontalAlignment.Right
            End With
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_DevolucionResguardo_Guardar(ByVal lsv As ListView, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, Optional ByVal TipoLote As Integer = 1) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim LotesID As Integer
        Dim Dt_Remisiones As New DataTable
        Dim Rutas As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)
        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")
            Rutas = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, TipoLote)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, CantidadRemisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            LotesID = Cn_Datos.EjecutarScalarT(Cmd)

            For Each Elemento In lsv.CheckedItems
                'Insertar Detalle
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisionesD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_lote", SqlDbType.Int, LotesID)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Actualizar Bo_Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "bo_boveda_StatusPorID")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, Elemento.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
            'Devuelta de Boveda
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Resguardos_StatusDevueltadeBoveda")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, LotesID)
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

#End Region

#Region "Parametros Locales"

    Public Shared Function fn_Locales_ObtenValores() As Array

        Return fn_ObtenValores(0, "Cat_ParametrosL_Read", "", True)
    End Function

    Public Shared Function fn_Locales_Actualizar(ByVal Gerente As Integer, ByVal RProceso As Decimal, ByVal RRuta As Decimal, ByVal Morralla As Char, _
                                             ByVal Verificador As Char, ByVal Banxico As Integer, ByVal Moneda As Integer) As Boolean
        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Sucursales_updateParam", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Gerente", SqlDbType.Int, Gerente)
        Cn_Datos.Crea_Parametro(Cmd, "@Linea_Rproceso", SqlDbType.Money, RProceso)
        Cn_Datos.Crea_Parametro(Cmd, "@Linea_Rruta", SqlDbType.Money, RRuta)
        Cn_Datos.Crea_Parametro(Cmd, "@Pro_ManipulaMorralla", SqlDbType.VarChar, Morralla)
        Cn_Datos.Crea_Parametro(Cmd, "@Clasifica_Verificador", SqlDbType.VarChar, Verificador)
        Cn_Datos.Crea_Parametro(Cmd, "@Cliente_Banxico", SqlDbType.Int, Banxico)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_Local", SqlDbType.Int, Moneda)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

    '#Region "Empleados"

    '    Public Shared Function fn_Empleados_ObtenValores(ByVal Id As Integer) As Array

    '        Return fn_ObtenValores(Id, "Cat_Empleados_Read", "@Id_Empleado", False)

    '    End Function

    '    Public Shared Function fn_Empleados_ValidarClave(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean
    '        If ClaveAnt = "" Then GoTo Validar
    '        If Not Clave = ClaveAnt Then GoTo Validar
    '        Return True
    '        Exit Function
    'Validar:
    '        Return fn_ValidarClave(Clave, "@Clave_Empleado", "Cat_EmpleadosClave_Read")

    '    End Function

    '    Public Shared Function fn_Empleados_LlenarLista(ByRef lsw As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean

    '        Return fn_LlenarLista("Cat_Empleados_Get", "Id_Empleado", lsw)

    '    End Function

    '    Public Shared Function fn_Empleados_Nuevo(ByVal Clave As String, ByVal Nombre As String, ByVal Departamento As Integer, ByVal Puesto As Integer, ByVal EstadoCivil As Integer, _
    '                                              ByVal Mail As String) As Boolean

    '        'Aqui se inserta un nuevo registro
    '        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

    '        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_Create", CommandType.StoredProcedure, Cnn)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Empleado", SqlDbType.VarChar, Clave)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, Nombre)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Departamento)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Puesto)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_EstadoCivil", SqlDbType.Int, EstadoCivil)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Mail", SqlDbType.VarChar, Mail)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

    '        Try
    '            Cn_Datos.EjecutarNonQuery(Cmd)
    '            Return True
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return False
    '        End Try
    '    End Function

    '    Public Shared Function fn_Empleados_Actualizar(ByVal Id As Integer, ByVal Clave As String, ByVal Nombre As String, ByVal Departamento As Integer, ByVal Puesto As Integer, ByVal EstadoCivil As Integer, _
    '                                              ByVal Mail As String) As Boolean

    '        'Aqui se actualiza un registro
    '        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

    '        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_Update", CommandType.StoredProcedure, Cnn)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Empleado", SqlDbType.VarChar, Clave)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, Nombre)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Departamento)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Puesto)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_EstadoCivil", SqlDbType.Int, EstadoCivil)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Mail", SqlDbType.VarChar, Mail)

    '        Try
    '            Cn_Datos.EjecutarNonQuery(Cmd)
    '            Return True
    '        Catch ex As Exception
    '            TrataEx(ex)
    '            Return False
    '        End Try

    '    End Function

    '    Public Shared Function fn_Empleados_Baja(ByVal Id As Integer) As Boolean

    '        Return fn_Status(Id, "B", "Cat_Empleados_Status", "@Id_Empleado")

    '    End Function

    '    Public Shared Function fn_Empleados_Alta(ByVal Id As Integer) As Boolean

    '        Return fn_Status(Id, "A", "Cat_Empleados_Status", "@Id_Empleado")

    '    End Function

    '    Public Shared Function fn_Empleados_ValidarDependencias(ByVal Id As Integer) As Boolean

    '        Return fn_ValidarDependencias(Id, "[Cat_Precios_GetEmpDep]", "@Id_Empresa")

    '    End Function

    '#End Region

#Region "Rutas"

    Public Shared Function fn_Rutas_ObtenValores(ByVal Id As Integer) As Array

        Return fn_ObtenValores(Id, "Cat_Rutas_Read", "@Id_Ruta", False)

    End Function

    Public Shared Function fn_Rutas_ValidarClave(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean
        If ClaveAnt = "" Then GoTo Validar
        If Not Clave = ClaveAnt Then GoTo Validar
        Return True
        Exit Function
Validar:
        Return fn_ValidarClave(Clave, "@Clave_Ruta", "Cat_RutasClave_Read")

    End Function

    Public Shared Function fn_Rutas_LlenarLista(ByRef lsw As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean

        Return fn_LlenarLista("Cat_Rutas_Get", "Id_Ruta", lsw)

    End Function

    Public Shared Function fn_Rutas_Nuevo(ByVal Clave As String, ByVal Descripcion As String, ByVal Tipo As Integer) As Boolean

        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Rutas_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Ruta", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Rutas_Actualizar(ByVal Id As Integer, ByVal Clave As String, ByVal Descripcion As String, ByVal Tipo As Integer) As Boolean

        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Rutas_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Ruta", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Rutas_Baja(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "B", "Cat_Rutas_Status", "@Id_Ruta")

    End Function

    Public Shared Function fn_Rutas_Alta(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "A", "Cat_Rutas_Status", "@Id_Ruta")

    End Function

    Public Shared Function fn_Rutas_ValidarDependencias(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Cat_Rutas_Dependencias", "@Id_Ruta")

    End Function

#End Region

#Region "Unidades"

    Public Shared Function fn_Unidades_ObtenValores(ByVal Id As Integer) As Array

        Return fn_ObtenValores(Id, "Cat_Unidades_Read", "@Id_Unidad", False)

    End Function

    Public Shared Function fn_Unidades_ValidarClave(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean
        If ClaveAnt = "" Then GoTo Validar
        If Not Clave = ClaveAnt Then GoTo Validar
        Return True
        Exit Function
Validar:
        Return fn_ValidarClave(Clave, "@Clave_Unidad", "Cat_UnidadesClave_Read")

    End Function

    Public Shared Function fn_Unidades_LlenarLista(ByRef lsw As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean

        Return fn_LlenarLista("Cat_Unidades_Get", "Id_Unidad", lsw)

    End Function

    Public Shared Function fn_Unidades_Nuevo(ByVal Clave As String, ByVal Descripcion As String, ByVal Marca As Integer, _
                                             ByVal Modelo As Integer, ByVal NumeroContable As String, ByVal Combustible _
                                             As Integer, ByVal Capacidad As Integer, ByVal Blindado As Char) As Boolean

        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Unidades_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Unidad", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Marca", SqlDbType.Int, Marca)
        Cn_Datos.Crea_Parametro(Cmd, "@Modelo", SqlDbType.Int, Modelo)
        Cn_Datos.Crea_Parametro(Cmd, "@Num_Conta", SqlDbType.VarChar, NumeroContable)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Combustible", SqlDbType.Int, Combustible)
        Cn_Datos.Crea_Parametro(Cmd, "@Capacidad_Tanque", SqlDbType.Int, Capacidad)
        Cn_Datos.Crea_Parametro(Cmd, "@Blindado", SqlDbType.VarChar, Blindado)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Unidades_Actualizar(ByVal Id As Integer, ByVal Clave As String, ByVal Descripcion As String, _
                                                  ByVal Marca As Integer, ByVal Modelo As Integer, ByVal NumeroContable As String, _
                                                  ByVal Combustible As Integer, ByVal Capacidad As Integer, ByVal Blindado As Char) As Boolean

        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Unidades_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Unidad", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Unidad", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Marca", SqlDbType.Int, Marca)
        Cn_Datos.Crea_Parametro(Cmd, "@Modelo", SqlDbType.Int, Modelo)
        Cn_Datos.Crea_Parametro(Cmd, "@Num_Conta", SqlDbType.VarChar, NumeroContable)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Combustible", SqlDbType.Int, Combustible)
        Cn_Datos.Crea_Parametro(Cmd, "@Blindado", SqlDbType.VarChar, Blindado)
        Cn_Datos.Crea_Parametro(Cmd, "@Capacidad_Tanque", SqlDbType.Int, Capacidad)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Unidades_Baja(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "B", "Cat_Unidades_Status", "@Id_Unidad")

    End Function

    Public Shared Function fn_Unidades_Alta(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "A", "Cat_Unidades_Status", "@Id_Unidad")

    End Function

    Public Shared Function fn_Unidades_ValidarDependencias(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Cat_Unidades_Dependencias", "@Id_Unidad")

    End Function

#End Region

#Region "Apertura Cierre de Bovedas"

    'Public Shared Function fn_Bovedas_ObtenValores(ByVal Id As Integer) As Array
    '    Return fn_ObtenValores(Id, "Cat_Bovedas_Read", "@Id_Boveda", False)
    'End Function
    '    Public Shared Function fn_Bovedas_ValidarClave(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean
    '        If ClaveAnt = "" Then GoTo Validar
    '        If Not Clave = ClaveAnt Then GoTo Validar
    '        Return True
    '        Exit Function
    'Validar:
    '        Return fn_ValidarClave(Clave, "@Clave_Boveda", "Cat_BovedasClave_Read")
    '    End Function

    Public Shared Function fn_Bovedas_LlenarLista(ByRef lsw As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Cat_Bovedas_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.VarChar, BovedaTipo) ' "P")

            lsw.Actualizar(Cmd, "Id_Boveda")
            If lsw.Items.Count > 0 Then
                lsw.Columns(2).TextAlign = HorizontalAlignment.Right
                lsw.Columns(3).TextAlign = HorizontalAlignment.Right
                lsw.Columns(5).TextAlign = HorizontalAlignment.Right
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Bovedas_Nuevo(ByVal Clave As String, ByVal Descripcion As String, ByVal Apertura As String, _
                                             ByVal Cierre As String, ByVal MonedaLR As Integer, ByVal ImporteLR _
                                             As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Bovedas_Create", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Boveda", SqlDbType.VarChar, Clave)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Cn_Datos.Crea_Parametro(Cmd, "@Hora_Apertura", SqlDbType.VarChar, Apertura)
            Cn_Datos.Crea_Parametro(Cmd, "@Hora_Cierre", SqlDbType.VarChar, Cierre)
            Cn_Datos.Crea_Parametro(Cmd, "@Moneda_LR", SqlDbType.Int, MonedaLR)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_LR", SqlDbType.Int, ImporteLR)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.EjecutarNonQuery(Cmd)

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_Actualizar(ByVal Id As Integer, ByVal Clave As String, ByVal Descripcion As String, ByVal Apertura As String, _
                                             ByVal Cierre As String, ByVal MonedaLR As Integer, ByVal ImporteLR _
                                             As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Bovedas_Update", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Boveda", SqlDbType.VarChar, Clave)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Cn_Datos.Crea_Parametro(Cmd, "@Hora_Apertura", SqlDbType.VarChar, Apertura)
            Cn_Datos.Crea_Parametro(Cmd, "@Hora_Cierre", SqlDbType.VarChar, Cierre)
            Cn_Datos.Crea_Parametro(Cmd, "@Moneda_LR", SqlDbType.Int, MonedaLR)
            Cn_Datos.Crea_Parametro(Cmd, "@Importe_LR", SqlDbType.Int, ImporteLR)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Bovedas_Apertura(ByVal Id_Boveda As Integer, ByVal Tipo As Integer, ByVal UsuarioBoveda As Integer, ByVal UsuarioSeg As Integer, ByVal Fecha As Date, ByVal Hora As String, ByVal FechaProxA As Date, ByVal HoraProxA As String, ByVal Observaciones As String) As Integer
        Dim ActaID As Integer = 0
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Try
            Dim Cmd As SqlCommand = Crea_Comando("Bo_Boveda_CreateAperturaCierre", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
            Crea_Parametro(Cmd, "@Usuario_Boveda", SqlDbType.Int, UsuarioBoveda)
            Crea_Parametro(Cmd, "@Usuario_Seguridad", SqlDbType.Int, UsuarioSeg)
            Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)
            Crea_Parametro(Cmd, "@Hora", SqlDbType.Time, Hora)
            Crea_Parametro(Cmd, "@Fecha_ProximaApertura", SqlDbType.Date, FechaProxA)
            Crea_Parametro(Cmd, "@Hora_ProximaApertura", SqlDbType.Time, HoraProxA)
            Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            ActaID = EjecutarScalar(Cmd)
            Return ActaID
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_Bovedas_Baja(ByVal Id_Boveda As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Bovedas_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_Abrir(ByVal Id_Boveda As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Bovedas_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_Alta(ByVal Id_Boveda As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Bovedas_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_Cerrar(ByVal Id_Boveda As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Bovedas_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "C")
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_ValidarDependencias(ByVal Id As Integer) As Boolean
        Return fn_ValidarDependencias(Id, "Cat_Bovedas_Dependencias", "@Id_Boveda")
    End Function

    Public Shared Function fn_Bovedas_MostrarActa(ByVal Id_Acta As Integer, ByVal Tipo As Integer) As Boolean
        'Aqui se imprime el Acta de Apertura y Cierre
        Dim frm As New frm_Acta
        Dim rpt As New rpt_Acta_AperturaCierre
        Dim ds As New ds_Acta_AperturaCierre

        fn_Bovedas_ObtenerDatosEmpresa(ds.DatosSucursal)
        fn_Boveda_ObtenerDatosActa(ds.Datos_AperturaCierre, Id_Acta)

        Dim Titulo As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section1.ReportObjects("txt_TituloActa")
        Dim TipoM As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("txt_Tipo")
        Dim condicion As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("txt_quedando")
        Dim TipoProx As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("txt_TipoProx")
        Dim ImporteLetras As CrystalDecisions.CrystalReports.Engine.TextObject = rpt.Section2.ReportObjects("txt_ImporteLetras")

        If Tipo = 1 Then
            Titulo.Text = "ACTA DE APERTURA DE BOVEDA"
            TipoM.Text = "la Apertura"
            condicion.Text = "habiendo"
            TipoProx.Text = "CIERRE"
            rpt.ProxApertura.SectionFormat.EnableSuppress = True
        Else
            Titulo.Text = "ACTA DE CIERRE DE BOVEDA"
            TipoM.Text = "el Cierre"
            condicion.Text = "quedando"
            TipoProx.Text = "APERTURA"
            rpt.ProxApertura.SectionFormat.EnableSuppress = False
        End If
        Dim s As String = CDec(FormatNumber(ds.Datos_AperturaCierre.Item(0).Saldo_Importe, 2))
        ImporteLetras.Text = fn_EnLetras(CDec(FormatNumber(ds.Datos_AperturaCierre.Item(0).Saldo_Importe, 2)), MonedaId) & " M.N."

        rpt.SetDataSource(ds)

        frm.crv_Acta.ReportSource = rpt

        frm.ShowDialog()

    End Function

    Public Shared Function fn_Bovedas_ObtenerDatosEmpresa(ByRef Tabla As ds_Acta_AperturaCierre.DatosSucursalDataTable) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Boveda_ObtenerDatosActa(ByRef Tabla As ds_Acta_AperturaCierre.Datos_AperturaCierreDataTable, ByVal Id_AperturaCierre As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_AperturaCierre_ReporteGet", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_AperturaCierre", SqlDbType.Int, Id_AperturaCierre)
        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_ReporteCierre(ByVal Id_Boveda As Integer) As Boolean
        'Aqui se imprime el Reporte de Saldo de Bóveda Antes del Cierre o Apertura
        Dim frm As New frm_Reporte
        Dim rpt As New rpt_ReporteCierre
        Dim ds As New ds_ReporteCierre

        fn_Bovedas_ObtenerDatosEmpresaCierre(ds.DatosSucursal)
        If BovedaTipo = "P" Then
            fn_Bovedas_SaldosClientes(ds.SaldoClientes, Id_Boveda) '(Tipo=1 and (DotacionATMs='N' Or CustodiaATMs='N' Or ConcentracionATMs='N'))
            fn_Bovedas_SaldosProceso(ds.SaldoProceso, Id_Boveda) '(Tipo=2 y TipoP in(1,2,3,4,10))
            fn_Bovedas_SaldosResguardos(ds.SaldoResguardos, Id_Boveda) '(Tipo=2 y TipoP in(5,6,7,8,9))
            'Falta una consulta para los resguardos(Tipo=2 y TipoP in(5,6,7,8,9))
        ElseIf BovedaTipo = "C" Then
            fn_Bovedas_SaldosCajeros(ds.SaldoCajeros, Id_Boveda) '(Tipo=3)
            fn_Bovedas_SaldosCajerosProceso(ds.SaldoCajerosProceso, Id_Boveda) '(Tipo=1 and (DotacionATMs='S' Or CustodiaATMs='S' Or ConcentracionATMs='S'))
        End If
        rpt.SetDataSource(ds)
        frm.crv.ReportSource = rpt
        Return frm.ShowDialog() = DialogResult.Yes

    End Function

    Public Shared Function fn_Bovedas_ObtenerDatosEmpresaCierre(ByRef Tabla As ds_ReporteCierre.DatosSucursalDataTable) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_SaldosClientes(ByRef Tabla As ds_ReporteCierre.SaldoClientesDataTable, ByVal Id_Boveda As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetSaldoCierre1", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_SaldosProceso(ByRef Tabla As ds_ReporteCierre.SaldoProcesoDataTable, ByVal Id_Boveda As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetSaldoCierre2", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_SaldosResguardos(ByRef Tabla As ds_ReporteCierre.SaldoResguardosDataTable, ByVal Id_Boveda As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetSaldoCierre4", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_SaldosCajeros(ByRef Tabla As ds_ReporteCierre.SaldoCajerosDataTable, ByVal Id_Boveda As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetSaldoCierre3", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, ID_Boveda)
        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_SaldosCajerosProceso(ByRef Tabla As ds_ReporteCierre.SaldoCajerosProcesoDataTable, ByVal Id_Boveda As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetSaldoCierre1C", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, ID_Boveda)

            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Maquinas"

    Public Shared Function fn_Maquinas_ObtenValores(ByVal Id As Integer) As Array
        Return fn_ObtenValores(Id, "Cat_Maquinas_Read", "@Id_Maquina", False)
    End Function

    Public Shared Function fn_Maquinas_LlenarLista(ByRef lsw As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean
        Return fn_LlenarLista("Cat_Maquinas_Get", "Id_Maquina", lsw)
    End Function

    Public Shared Function fn_Maquinas_Nuevo(ByVal Nombre As String, ByVal IP As String, ByVal MAC As String, ByVal Tipo As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Maquinas_Create", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Nombre_Maquina", SqlDbType.VarChar, Nombre)
            Cn_Datos.Crea_Parametro(Cmd, "@IP", SqlDbType.VarChar, IP)
            Cn_Datos.Crea_Parametro(Cmd, "@MAC", SqlDbType.VarChar, MAC)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.EjecutarNonQuery(Cmd)

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Maquinas_Actualizar(ByVal Id As Integer, ByVal Nombre As String, ByVal IP As String, ByVal MAC As String, ByVal Tipo As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Maquinas_Update", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Maquina", SqlDbType.Int, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@Nombre_Maquina", SqlDbType.VarChar, Nombre)
            Cn_Datos.Crea_Parametro(Cmd, "@IP", SqlDbType.VarChar, IP)
            Cn_Datos.Crea_Parametro(Cmd, "@MAC", SqlDbType.VarChar, MAC)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
            Cn_Datos.EjecutarNonQuery(Cmd)

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Maquinas_Baja(ByVal Id As Integer) As Boolean
        Return fn_Status(Id, "B", "Cat_Maquinas_Status", "@Id_Maquina")
    End Function

    Public Shared Function fn_Maquinas_Alta(ByVal Id As Integer) As Boolean
        Return fn_Status(Id, "A", "Cat_Maquinas_Status", "@Id_Maquina")
    End Function

#End Region

#Region "Dispositivos"

    Public Shared Function fn_Dispositivos_ObtenValores(ByVal Id As Integer) As Array

        Return fn_ObtenValores(Id, "Cat_Dispositivos_Read", "@Id_Dispositivo", False)

    End Function

    Public Shared Function fn_Dispositivos_ValidarClave(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean
        If ClaveAnt = "" Then GoTo Validar
        If Not Clave = ClaveAnt Then GoTo Validar
        Return True
        Exit Function
Validar:
        Return fn_ValidarClave(Clave, "@Clave_Dispositivo", "Cat_DispositivosClave_Read")

    End Function

    Public Shared Function fn_Dispositivos_LlenarLista(ByRef lsw As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean

        Return fn_LlenarLista("Cat_Dispositivos_Get", "Id_Dispositivo", lsw)

    End Function

    Public Shared Function fn_Dispositivos_Nuevo(ByVal Clave As String, ByVal Marca As String, ByVal Modelo As String, _
                                             ByVal Serie As String, ByVal Observaciones As String) As Boolean

        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Dispositivos_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Dispositivo", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Marca", SqlDbType.VarChar, Marca)
        Cn_Datos.Crea_Parametro(Cmd, "@Modelo", SqlDbType.VarChar, Modelo)
        Cn_Datos.Crea_Parametro(Cmd, "@Serie", SqlDbType.VarChar, Serie)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Dispositivos_Actualizar(ByVal Id As Integer, ByVal Clave As String, ByVal Marca As String, ByVal Modelo As String, _
                                             ByVal Serie As String, ByVal Observaciones As String) As Boolean

        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Dispositivos_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Dispositivo", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Dispositivo", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Marca", SqlDbType.VarChar, Marca)
        Cn_Datos.Crea_Parametro(Cmd, "@Modelo", SqlDbType.VarChar, Modelo)
        Cn_Datos.Crea_Parametro(Cmd, "@Serie", SqlDbType.VarChar, Serie)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Dispositivos_Baja(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "B", "Cat_Dispositivos_Status", "@Id_Dispositivo")

    End Function

    Public Shared Function fn_Dispositivos_Alta(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "A", "Cat_Dispositivos_Status", "@Id_Dispositivo")

    End Function

    Public Shared Function fn_Dispositivos_ValidarDependencias(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Cat_Dispositivos_Dependencias", "@Id_Dispositivo")

    End Function

#End Region

#Region "Grupos de Deposito"

    Public Shared Function fn_GrupoDeposito_ObtenValores(ByVal Id As Integer) As Array

        Return fn_ObtenValores(Id, "Cat_GrupoDeposito_Read", "@Id_GrupoDepo", False)

    End Function

    Public Shared Function fn_GrupoDeposito_ValidarClave(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean

        If ClaveAnt = "" Then GoTo Validar
        If Not Clave = ClaveAnt Then GoTo Validar
        Return True
        Exit Function
Validar:

        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDepositoClave_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Grupo", SqlDbType.VarChar, Clave)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GrupoDeposito_LlenarLista(ByRef lsw As cp_Listview, ByRef CS As ListViewColumnSorter, ByVal Id_CajaBancaria As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDeposito_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")

            'Aqui se Actualiza la lista
            lsw.Actualizar(Cmd, "Id_GrupoDepo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GrupoDeposito_Nuevo(ByVal Clave As String, ByVal Descripcion As String, ByVal Caja As Integer) As Boolean

        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDeposito_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Grupo", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Caja)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GrupoDeposito_Actualizar(ByVal Id As Integer, ByVal Clave As String, ByVal Descripcion As String) As Boolean

        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDeposito_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_GrupoDepo", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Grupo", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GrupoDeposito_Baja(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "B", "Cat_GrupoDeposito_Status", "@Id_GrupoDepo")

    End Function

    Public Shared Function fn_GrupoDeposito_Alta(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "A", "Cat_GrupoDeposito_Status", "@Id_GrupoDepo")

    End Function

    Public Shared Function fn_GrupoDeposito_ValidarDependencias(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Cat_GrupoDeposito_Dependencias", "@Id_GrupoDepo")

    End Function

#End Region

#Region "Grupos de Dotaciones"

    Public Shared Function fn_GrupoDota_ObtenValores(ByVal Id As Integer) As Array

        Return fn_ObtenValores(Id, "Cat_GrupoDota_Read", "@Id_GrupoDota", False)

    End Function

    Public Shared Function fn_GrupoDota_ValidarClave(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean

        If ClaveAnt = "" Then GoTo Validar
        If Not Clave = ClaveAnt Then GoTo Validar
        Return True
        Exit Function
Validar:

        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDotaClave_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Grupo", SqlDbType.VarChar, Clave)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GrupoDota_LlenarLista(ByRef lsw As cp_Listview, ByRef CS As ListViewColumnSorter, ByVal Id_CajaBancaria As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDota_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Id_CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")

            'Aqui se Actualiza la lista
            lsw.Actualizar(Cmd, "Id_GrupoDota")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GrupoDota_Nuevo(ByVal Clave As String, ByVal Descripcion As String, ByVal Caja As Integer) As Boolean

        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDota_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Grupo", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, Caja)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GrupoDota_Actualizar(ByVal Id As Integer, ByVal Clave As String, ByVal Descripcion As String) As Boolean

        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GrupoDota_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_GrupoDota", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Grupo", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GrupoDota_Baja(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "B", "Cat_GrupoDota_Status", "@Id_GrupoDota")

    End Function

    Public Shared Function fn_GrupoDota_Alta(ByVal Id As Integer) As Boolean

        Return fn_Status(Id, "A", "Cat_GrupoDota_Status", "@Id_GrupoDota")

    End Function

    Public Shared Function fn_GrupoDota_ValidarDependencias(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Cat_GrupoDota_Dependencias", "@Id_GrupoDota")

    End Function

#End Region

#Region "Consulta Entradas"

    Public Shared Function fn_ConsultaEntradasRutasLlenalista(ByVal lsv As cp_Listview, ByVal Id_Boveda As Integer, ByVal Ruta As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetConsultaEntradasRutas2", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta", SqlDbType.Int, Ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            lsv.Actualizar(Cmd, "Id_Bo")
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConsultaEntradasRutasExtLlenalista(ByVal lsv As cp_Listview, ByVal Boveda As Integer, ByVal Id_Cia As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetConsultaEntradasRutasExt", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Boveda)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            lsv.Actualizar(Cmd, "Id_Bo")
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(9).Width = 0
            lsv.Columns(10).Width = 0
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConsultaEntradasLlenalista(ByVal lsv As cp_Listview, ByVal Id_Boveda As Integer, ByVal Tipop As Integer, ByVal IdCia As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetConsultaEntradas", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, IdCia)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, Tipop)
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            lsv.Actualizar(Cmd, "Id_Bo")
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(9).Width = 0
            lsv.Columns(10).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConsultaEntradasLlenalistaATMs(ByVal lsv As cp_Listview, ByVal Id_Boveda As Integer, ByVal Id_Cia As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetConsultaEntradasATMs", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            lsv.Actualizar(Cmd, "Id_Bo")
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            lsv.Columns(9).Width = 0
            lsv.Columns(10).Width = 0
            lsv.Columns(12).Width = 100
            lsv.Columns(12).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConsultaEntradasLlenaResguardos(ByVal lsv As cp_Listview, ByVal Id_Boveda As Integer, ByVal Desde As DateTime, ByVal Hasta As DateTime) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetConsultaEntradasResguardos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Fecha_Inicial", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Fecha_Final", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
        Cn_Datos.Crea_Parametro(cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)
        Try
            lsv.Actualizar(cmd, "Id_Bo")
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(9).Width = 0
            lsv.Columns(10).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultasInternasLlenaResguardosSalida(ByVal lsv As cp_Listview, ByVal Id_Boveda As Integer, ByVal Desde As DateTime, ByVal Hasta As DateTime) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_SalidasGet", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Fecha_Inicial", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Fecha_Final", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@Boveda", SqlDbType.Int, Id_Boveda)
        Try
            lsv.Actualizar(cmd, "Id_Bo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Consulta Salidas"

    Public Shared Function fn_ConsultaSalidasRutasLlenalista(ByVal lsv As cp_Listview, ByVal Id_Boveda As Integer, ByVal Ruta As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetConsultaSalidasRutas2", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            If Id_Boveda <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
            End If
            If Ruta <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Ruta", SqlDbType.Int, Ruta)
            End If
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            lsv.Actualizar(Cmd, "Id_Bo")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConsultaSalidasRutasExtLlenalista(ByVal lsv As cp_Listview, ByVal Boveda As Integer, ByVal Id_Cia As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetConsultaSalidasRutasExt", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            If Boveda <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Boveda)
            End If
            If Id_Cia <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            End If
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)
            lsv.Actualizar(Cmd, "Id_Bo")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConsultaSalidasLlenalista(ByVal lsv As cp_Listview, ByVal Id_Boveda As Integer, ByVal Tipop As Integer, ByVal IdCia As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetConsultaSalidas", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            If Id_Boveda <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
            End If
            If IdCia <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, IdCia)
            End If
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, Tipop)
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)
            lsv.Actualizar(Cmd, "Id_Bo")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConsultaSalidasLlenalistaATMs(ByVal lsv As cp_Listview, ByVal Id_Boveda As Integer, ByVal Id_Cia As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetConsultaSalidasATMs", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            If Id_Boveda <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
            End If
            If Id_Cia <> 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            End If
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, Desde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, Hasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)
            lsv.Actualizar(Cmd, "Id_Bo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConsultaSalidasLlenaResguardos(ByVal lsv As cp_Listview, ByVal Id_Boveda As Integer, ByVal Desde As DateTime, ByVal Hasta As DateTime) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetConsultaSalidasResguardos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Fecha_Inicial", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Fecha_Final", SqlDbType.Date, Hasta)
        Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
        Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "B")
        Cn_Datos.Crea_Parametro(cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)
        Try
            lsv.Actualizar(cmd, "Id_Bo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Cambio de Turno"
    Public Shared Function fn_CambioTurnoH() As Array

        Return fn_ObtenValores(0, "Bo_Turnos_Get", "", True)

    End Function

    Public Shared Function fn_CambioTurno_LlenarLista(ByRef Lista As cp_Listview, ByVal Id_Turno As Long) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Bo_TurnosCambio_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.BigInt, Id_Turno)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_Ruta")
            If Lista.Items.Count > 0 Then
                Lista.Columns(2).TextAlign = HorizontalAlignment.Right
                Lista.Columns(3).TextAlign = HorizontalAlignment.Right
                Lista.Columns(4).TextAlign = HorizontalAlignment.Right
                Lista.Columns(5).TextAlign = HorizontalAlignment.Right
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CambioTurno_Nuevo(ByVal lsv As ListView, ByVal IDturno As Integer, ByVal turno As Integer, ByVal UsuarioEntrega As Integer, ByVal UsuarioRecibe As Integer) As Boolean
        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim lc_identity As Integer
        Dim Elemento As ListViewItem

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            'BO_Turnos_Status
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Turnos_Status")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, IDturno)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Cierre", SqlDbType.VarChar, UsuarioEntrega)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")

            Cn_Datos.EjecutarNonQueryT(Cmd)


            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Turnos_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Turno", SqlDbType.Int, turno + 1)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Apertura", SqlDbType.Int, UsuarioRecibe)

            lc_identity = Cn_Datos.EjecutarScalarT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        TurnoId = lc_identity
        Return True

    End Function

#End Region

#Region "Entrada Materiales a Boveda"

    Public Shared Function fn_EntradaMateriales_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByVal Tipolote As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("CAT_LotesRemisiones_EnvioBoveda", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, Tipolote)

            'Aqui se Actualiza la lista
            lsv_Catalogo.Actualizar(Cmd, "Id_Lote")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EntradaMateriales_Guardar(ByVal BovedaID As Integer, ByVal lsvH As ListView) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim ElementoH As ListViewItem
        Dim dt As New DataTable
        Dim dr_detalle As DataRow

        Dim Rutas As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")

            Rutas = Cn_Datos.EjecutarScalarT(Cmd)


            For Each ElementoH In lsvH.CheckedItems

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisionesD_MaterialesGet")
                Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, ElementoH.Tag)

                dt = Cn_Datos.EjecutaConsultaT(Cmd)


                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_StatusValida")
                Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, ElementoH.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Materiales_StatusRecibidaEnBoveda")
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Mat_Materiales_StatusRecibidaEnBovedaNew")
                Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, ElementoH.Tag)

                Cn_Datos.EjecutarNonQueryT(Cmd)



                For Each dr_detalle In dt.Rows

                    'Inserta En Bo_Boveda

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Boveda_Create")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
                    Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)
                    Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, dr_detalle(8))
                    Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, dr_detalle(8))
                    Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 0)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, dr_detalle(7))
                    Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Rutas)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, 0)
                    Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
                    Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "S")
                    Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Salida", SqlDbType.DateTime, dr_detalle.Item("FE"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")

                    Cn_Datos.EjecutarNonQueryT(Cmd)

                Next  ' Detalle


            Next  'Encabezado


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False

        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True


    End Function

    Public Shared Function fn_EnvioaBovedaD_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter, ByVal ID_lote As Integer) As Boolean

        Return fn_LlenarListaD("CAT_LotesRemisionesD_MaterialesGet", "Id_Lote", lsv_Catalogo, ID_lote)

    End Function

    Public Shared Function fn_EnvioaBovedaD_LlenarListaEnvase(ByVal lsv As ListView, ByVal ID_Lote As Integer) As DataTable

        Dim dt As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD 'Cat_LotesRemisionesD_GETDotacionesPro
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("CAT_LotesRemisionesD_MaterialesGetEnvase", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, ID_Lote)
        Try
            dt = EjecutaConsulta(Cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_EnvioaBoveda_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean

        Return fn_LlenarLista("CAT_LotesRemisiones_MaterialesGET", "Id_Lote", lsv_Catalogo, True)

    End Function

#End Region

#Region "Devolucion de Materiales"

    Public Shared Function fn_DevolucionMateriales_LlenarLista(ByRef lsv As cp_Listview, ByRef CS As ListViewColumnSorter) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_MaterialGet", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "S")
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            With lsv
                .Actualizar(Cmd, "Id_Bo")
                .Columns(3).TextAlign = HorizontalAlignment.Right
                .Columns(4).TextAlign = HorizontalAlignment.Right
                .Columns(5).TextAlign = HorizontalAlignment.Right
            End With
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function



    Public Shared Function fn_DevolucionMateriales_Guardar(ByVal lsv As ListView, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, Optional ByVal TipoLote As Integer = 1) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim LotesID As Integer
        Dim Dt_Remisiones As New DataTable
        Dim Rutas As Integer
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")
            Rutas = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, TipoLote)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, CantidadRemisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            LotesID = Cn_Datos.EjecutarScalarT(Cmd)

            For Each Elemento In lsv.CheckedItems

                'Insertar Detalle
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisionesD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_lote", SqlDbType.Int, LotesID)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Actualizar Bo_Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "bo_boveda_StatusPorID")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, Elemento.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False

        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True

    End Function

#End Region

#Region "Devolucion Resg a Cajeros"

    Public Shared Function fn_DevolucionResguardos_Valida(ByVal Id As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Boveda_StatusValida")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            If Cn_Datos.EjecutarNonQueryT(Cmd) = 0 Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()

    End Function

    Public Shared Function fn_DevolucionResguardos_LlenarLista(ByRef lsv_Catalogo As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetDevolucionResg", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            lsv_Catalogo.Actualizar(Cmd, "Id_Bo")
            lsv_Catalogo.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv_Catalogo.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_DevolucionResguardos_Guardar(ByVal lsv As ListView, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, Optional ByVal TipoLote As Integer = 1) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim LotesID As Integer
        Dim Dt_Remisiones As New DataTable
        Dim Rutas As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)


        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")

            Rutas = Cn_Datos.EjecutarScalarT(Cmd)


            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, TipoLote)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, CantidadRemisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            LotesID = Cn_Datos.EjecutarScalarT(Cmd)



            For Each Elemento In lsv.CheckedItems

                'Insertar Detalle
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisionesD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_lote", SqlDbType.Int, LotesID)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(5).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)


                'Actualizo Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_BovedaStatusSalida_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(5).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoSalida", SqlDbType.Int, TurnoId)

                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next

            'Devuelta de Boveda
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Resguardos_StatusDevueltadeBoveda")
            Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, LotesID)
            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False

        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True


    End Function

#End Region

#Region "Entrada de Resguardos"

    Public Shared Function fn_EntradaResguardoLlenalista(ByVal lsv As cp_Listview) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_lotesRemisiones_GET", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Lote")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EntradaResguardoDLlenalista(ByVal lsv As cp_Listview, ByVal ID_Lote As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRemisionesD_GETResguardos", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@ID_Lote", SqlDbType.Int, ID_Lote)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Lote")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EntradaResguardoD_Llenalista(ByVal lsv As cp_Listview, ByVal Id_Lote As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRemisionesD_GETRegre", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, Id_Lote)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Lote")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EntradaResguardo_Guardar(ByVal BovedaID As Integer, ByVal lsvH As ListView) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim dt As New DataTable
        Dim dr_detalle As DataRow
        Dim ElementoH As ListViewItem


        Dim Rutas As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)


        Try


            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")

            Rutas = Cn_Datos.EjecutarScalarT(Cmd)


            For Each ElementoH In lsvH.CheckedItems


                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_lotesRemisionesD_GET")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Lote", SqlDbType.Int, ElementoH.Tag)

                dt = Cn_Datos.EjecutaConsultaT(Cmd)

                'cambiar estatus a RB
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Resguardos_StatusRecibidaEnBoveda")
                Cn_Datos.Crea_Parametro(Cmd, "@ID_lote", SqlDbType.Int, ElementoH.Tag)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_LotesRemisiones_StatusValida")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, ElementoH.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

                Cn_Datos.EjecutarNonQueryT(Cmd)

                For Each dr_detalle In dt.Rows

                    'Inserta En Bo_Boveda

                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Boveda_Create")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
                    Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 2)
                    Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, dr_detalle(8).ToString)
                    Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, 0)
                    Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, dr_detalle(6).ToString)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, dr_detalle(7).ToString)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Rutas)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, 0)
                    Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
                    Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")

                    Cn_Datos.EjecutarNonQueryT(Cmd)

                Next  ' Detalle


            Next  'Encabezado


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False

        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True


    End Function

#End Region

#Region "Entrada de Servicios Regresados de Proceso"

    Public Shared Function fn_EntradaServiciosRegLlenalista(ByVal lsv As cp_Listview, ByVal Tipo_Lote As Integer, ByVal Status As String) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_lotesRemisiones_GETGnr", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, Tipo_Lote)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Lote")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_EntradaServiciosRegDLlenalista(ByVal lsv As cp_Listview, ByVal ID_Lote As Integer) As Boolean

        Try
            'Aqui se llena el listview Detalle
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_lotesRemisionesD_GET", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@ID_Lote", SqlDbType.Int, ID_Lote)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Lote")
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EntradaServiciosReg_Guardar(ByVal BovedaID As Integer, ByVal lsvH As ListView, ByVal Id_Usuario As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim dt As New DataTable
        Dim dr_detalle As DataRow
        Dim ElementoH As ListViewItem
        Dim Rutas As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            'Obtener la Ruta REXT
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3) '--Interna
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")
            Rutas = Cn_Datos.EjecutarScalarT(Cmd)

            'Recorrer cada elemento seleccionado y guardarlo
            For Each ElementoH In lsvH.CheckedItems
                'Consultar todas las temisiones del Lote
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_LotesRemisionesD_GETregre")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@ID_Lote", SqlDbType.Int, ElementoH.Tag)
                dt = Cn_Datos.EjecutaConsultaT(Cmd)

                'Cambiar el Status del Lote
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_LotesRemisiones_StatusValida")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, ElementoH.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, Id_Usuario)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                For Each dr_detalle In dt.Rows

                    'cambiar el estatus de cada ServicioP dentro del lote a DV
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Servicios_StatusRemision")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, dr_detalle("Id_Remision"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "DV")
                    Cn_Datos.EjecutarNonQueryT(Cmd)

                    'Buscarlo en Bo_Boveda y cambiarle los valores de entrada y el status
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Boveda_Status")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, dr_detalle("Id_Remision"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                Next  ' Detalle
            Next  'Encabezado
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

#End Region

#Region "Entrada Dotaciones Cajeros"

    Public Shared Function fn_EntradaDotacionesCajeros_LlenarLista(ByRef lsv_Catalogo As cp_Listview, ByVal Tipolote As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("CAT_LotesRemisiones_EnvioBoveda", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, Tipolote)
            lsv_Catalogo.Actualizar(Cmd, "Id_Lote")
            lsv_Catalogo.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv_Catalogo.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EntradaDotacionesCajerosD_Llenalista(ByVal lsv As ListView, ByVal ID_Lote As Integer) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD 'Cat_LotesRemisionesD_GETDotacionesPro
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRemisionesD_GetDotaCajeros", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, ID_Lote)
            'Aqui se Actualiza la lista
            'lsv.Actualizar(Cmd, "Id_Dotacion")
            Cmd.Connection.Open()
            FuncionesGlobales.fn_CargaListaCMDtag(Cmd, lsv, 0, "Id_Dotacion")
            Cmd.Connection.Close()
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            lsv.Columns(10).TextAlign = HorizontalAlignment.Right
            lsv.Columns(0).Width = 70
            lsv.Columns(1).Width = 70
            lsv.Columns(2).Width = 100
            lsv.Columns(3).Width = 140
            lsv.Columns(4).Width = 180
            lsv.Columns(5).Width = 90
            lsv.Columns(6).Width = 200
            lsv.Columns(7).Width = 100
            lsv.Columns(8).Width = 100
            lsv.Columns(9).Width = 100
            lsv.Columns(10).Width = 80
            lsv.Columns(11).Width = 0
            lsv.Columns(12).Width = 0
            lsv.Columns(13).Width = 0
            lsv.Columns(14).Width = 0
            lsv.Columns(15).Width = 0
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EntradaDotacionesCajerosD_LlenalistaEnvases(ByVal lsv As ListView, ByVal ID_Lote As Integer) As DataTable


        Dim dt As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD 'Cat_LotesRemisionesD_GETDotacionesPro
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRemisionesD_GetDotaCajerosEnvases", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, ID_Lote)
        Try
            dt = EjecutaConsulta(Cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_EntradaDotacionesCajerosDPro_Llenalista(ByVal lsv As ListView, ByVal ID_Lote As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRemisionesD_GETDotacionesPro", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@ID_Lote", SqlDbType.Int, ID_Lote)

            'Aqui se Actualiza la lista
            'lsv.Actualizar(Cmd, "Id_Lote")
            'Se cambió el CP_Listview por un Listview normal para que no afecte el acomodo de las columnas ya que
            'se utiliza el mismo listview para las dotaciones de Cajeros y las de Proceso
            Cmd.Connection.Open()
            FuncionesGlobales.fn_CargaListaCMDtag(Cmd, lsv, 0, "Id_Lote")
            Cmd.Connection.Close()
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(0).Width = 100
            lsv.Columns(1).Width = 100
            lsv.Columns(2).Width = 100
            lsv.Columns(3).Width = 0
            lsv.Columns(4).Width = 0
            lsv.Columns(5).Width = 0
            lsv.Columns(6).Width = 0
            lsv.Columns(7).Width = 0
            lsv.Columns(8).Width = 0
            lsv.Columns(9).Width = 0
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_EntradaDotacionesCajerosDPro_LlenalistaEnvases(ByVal lsv As ListView, ByVal ID_Lote As Integer) As DataTable

        'Aqui se llena el listview
        Dim dt As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_LotesRemisionesD_GETDotacionesProEnvases", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@ID_Lote", SqlDbType.Int, ID_Lote)

        Try
            dt = EjecutaConsulta(Cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_EntradaDotacionesCajeros_Guardar(ByVal BovedaID As Integer, ByVal lsvH As ListView) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim dr_Detalle As DataRow
        Dim ElementoH As ListViewItem
        Dim Rutas As Integer
        Dim dt_Detalle As New DataTable
        Dim Fecha_Salida As String = ""

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")
            Rutas = Cn_Datos.EjecutarScalarT(Cmd)

            For Each ElementoH In lsvH.CheckedItems
                'Consultar las Dotaciones que forman el Lote que se está recibiendo
                If ElementoH.SubItems(5).Text = "CAJEROS" Or ElementoH.SubItems(5).Text = "AUDITORIA ATMS" Then
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_LotesRemisionesD_GetDotaCajeros")
                Else
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_LotesRemisionesD_GETDotacionesPro")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                End If
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, ElementoH.Tag)
                dt_Detalle = Cn_Datos.EjecutaConsultaT(Cmd)

                'Validar el Lote
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_StatusValida")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, ElementoH.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                'marcar las Dotaciones como Recibidas en Bóveda
                If ElementoH.SubItems(5).Text = "CAJEROS" Or ElementoH.SubItems(5).Text = "AUDITORIA ATMS" Then
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_Dotaciones_StatusRecibidaEnBoveda")
                Else
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_Dotaciones_StatusRecibidaEnBoveda")
                End If
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, ElementoH.Tag)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Dim Tipo, TipoP, Entidad_Origen, Entidad_Destino, Ruta_Salida As Integer
                Dim Remision As Long

                'Recorrer cada una de las Dotaciones del Lote
                For Each dr_Detalle In dt_Detalle.Rows
                    If ElementoH.SubItems(5).Text = "CAJEROS" Or ElementoH.SubItems(5).Text = "AUDITORIA ATMS" Then
                        Tipo = 1
                        TipoP = 0
                        Remision = dr_Detalle("IDR").ToString
                        Entidad_Origen = dr_Detalle("IDCB").ToString
                        Entidad_Destino = dr_Detalle("IDC").ToString
                        Ruta_Salida = dr_Detalle("IDRU").ToString
                        Fecha_Salida = dr_Detalle("Fecha Entrega").ToString
                    Else
                        'Id_Remision		Columna 4,
                        'Id_ClienteP		Columna 5,
                        'Id_CajaBancaria	Columna 6,
                        'Id_Ruta			Columna 7,
                        'Id_Cia             Columna 8,
                        'Id_ClienteP        Columna 9
                        If dr_Detalle(8) = CiaId Then
                            Tipo = 1
                            TipoP = 0
                            Entidad_Origen = dr_Detalle(9).ToString
                            Entidad_Destino = dr_Detalle(10).ToString
                        Else
                            Tipo = 2
                            TipoP = 2
                            Entidad_Origen = dr_Detalle(5).ToString
                            Entidad_Destino = 0
                        End If
                        Remision = dr_Detalle(4).ToString
                        Ruta_Salida = dr_Detalle(7)
                        Fecha_Salida = dr_Detalle("FE").ToString
                    End If

                    Dim DotacionPro As Char = "N"
                    Dim DotacionMorr As Char = "N"
                    Dim DotacionATM As Char = "N"
                    Dim DotacionNom As Char = "N"

                    Select Case ElementoH.SubItems(5).Text
                        Case "CAJEROS"
                            DotacionATM = "S"
                        Case "PROCESO"
                            DotacionPro = "S"
                        Case "MORRALLA"
                            DotacionMorr = "S"
                        Case "NOMINAS"
                            DotacionNom = "S"
                        Case "AUDITORIA ATMS"
                            DotacionATM = "S"
                    End Select

                    'Inserta En Bo_Boveda
                    'Cuando ya existia en Bo_Boveda, se quedan los mismos datos, solo se actualiza el Status,
                    'Id_Boveda, Fecha_Entrada, Usuario_Entrada
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "BO_Boveda_Create")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
                    Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
                    Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, Entidad_Origen)
                    Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, Entidad_Destino)
                    Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, TipoP)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Remision)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Rutas)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, Ruta_Salida)
                    Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
                    Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, DotacionPro)
                    Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, DotacionMorr)
                    Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, DotacionATM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "N")
                    Cn_Datos.Crea_Parametro(Cmd, "@DotacionNom", SqlDbType.VarChar, DotacionNom)
                    Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Salida", SqlDbType.DateTime, Fecha_Salida)
                    Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")

                    Cn_Datos.EjecutarNonQueryT(Cmd)
                    
                Next  ' Detalle
            Next  'Encabezado
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False

        End Try

        lc_Transaccion.Commit()
        Cnn.Close()
        Return True
    End Function

    Public Shared Function fn_Get_Envases(ByVal lsv As cp_Listview, ByVal Id_Dotacion As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get10", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Dotacion", SqlDbType.Int, Id_Dotacion)

            lsv.Actualizar(cmd, "Id_Envase")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_Get_Envases3(ByVal lsv As cp_Listview, ByVal Id_Boveda As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get13", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)

            lsv.Actualizar(cmd, "Id_Envase")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_Get_Envases4(ByVal lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get12", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

            lsv.Actualizar(cmd, "Id_Envase")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecLotesBoveda_Validar(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "CAT_LotesRemisiones_Statusvalidar", "@ID_lote")

    End Function


    Public Shared Function fn_AsignarProcesoRetenidosLlenalistaEnvase(ByVal lsv As cp_Listview, ByVal CajaBancaria As Integer, ByVal Cia As Integer, ByVal DeptoRegistro As Char) As DataTable

        Try
            Dim dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetAsignarProcesoEnvases", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Cia)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)
            Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, DeptoRegistro) 'new 24/05/2014

            dt = EjecutaConsulta(Cmd)


            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function



#End Region

#Region "Devolucion Dotacion"

    Public Shared Function fn_DevolucionDotacion_Valida(ByVal Id As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_Boveda_StatusValida")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, Id)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            If Cn_Datos.EjecutarNonQueryT(Cmd) = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        lc_Transaccion.Commit()

    End Function

    Public Shared Function fn_DevolucionDotacion_LlenarLista(ByRef lsv_Catalogo As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetDevolucionDotacion", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            With lsv_Catalogo
                .Actualizar(Cmd, "Id_Bo")
                .Columns(3).TextAlign = HorizontalAlignment.Right
                .Columns(4).TextAlign = HorizontalAlignment.Right
                .Columns(5).TextAlign = HorizontalAlignment.Right
                .Columns(10).Width = 0
            End With
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_DevolucionDotacion_LlenarListaPro(ByRef lsv_Catalogo As cp_Listview, ByVal Tipo As Char) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetDevolucionDotacionProceso", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.VarChar, Tipo)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            With lsv_Catalogo
                .Actualizar(Cmd, "Id_Bo")
                .Columns(3).TextAlign = HorizontalAlignment.Right
                .Columns(4).TextAlign = HorizontalAlignment.Right
                .Columns(5).TextAlign = HorizontalAlignment.Right
                .Columns(10).Width = 0
            End With
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DevolucionDotacion_Guardar(ByVal lsv As ListView, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, Optional ByVal TipoLote As Integer = 1) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim LotesID As Integer
        Dim Dt_Remisiones As New DataTable
        Dim Rutas As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3) '-Interna
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")

            Rutas = Cn_Datos.EjecutarScalarT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, TipoLote)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, CantidadRemisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            LotesID = Cn_Datos.EjecutarScalarT(Cmd)

            For Each Elemento In lsv.CheckedItems
                'Insertar Detalle
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisionesD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Lote", SqlDbType.Int, LotesID)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Actualizo Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_BovedaStatusSalida_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoSalida", SqlDbType.Int, TurnoId)

                Cn_Datos.EjecutarNonQueryT(Cmd)

                'Actualizo Dotaciones
                Select Case lsv.Name.ToUpper
                    Case "LSV_DOTACION"
                        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Caj_dotaciones_StatusByRemision")
                    Case Else
                        Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Pro_dotaciones_StatusByRemision")
                End Select

                Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "DB")

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next

            lc_Transaccion.Commit()
            Cnn.Close()
            Return True
        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Menu"

    Public Shared Function fn_Menu_TipoCambio() As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_TipoCambio_Copiar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            Return EjecutarNonQuery(cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Concentraciones ATM"

    Public Shared Function fn_ConcentracionesLlenalista(ByVal lsv As cp_Listview) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_BovedaConATM_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Bo")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConcentracionesLlenalistaEnvases(ByVal lsv As cp_Listview) As DataTable

        Try
            'Aqui se llena el listview
            Dim dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_BovedaConATM_GetEnvases", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            dt = EjecutaConsulta(Cmd)
            Return dt

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Servicios_Llenalista(ByVal lsv As cp_Listview) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_BovedaServicios_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Bo")
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Servicios_LlenalistaEnvases(ByVal lsv As cp_Listview) As DataTable

        Try
            'Aqui se llena el listview
            Dim dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_bovedaServicios_GetEnvases", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            dt = EjecutaConsulta(Cmd)
            Return dt

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_DevConcentracionATS_Guardar(ByVal lsv As ListView, ByVal CantidadRemisiones As Integer, ByVal CantidadEnvases As Integer, Optional ByVal TipoLote As Integer = 1) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Elemento As ListViewItem
        Dim LotesID As Integer
        Dim Dt_Remisiones As New DataTable
        Dim Rutas As Integer

        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)


        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_RutasTipo_Get")

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "REXT")

            Rutas = Cn_Datos.EjecutarScalarT(Cmd)


            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisiones_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Lote", SqlDbType.Int, TipoLote)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Turno", SqlDbType.Int, TurnoId)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Envia", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, CantidadRemisiones)
            Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

            LotesID = Cn_Datos.EjecutarScalarT(Cmd)


            For Each Elemento In lsv.CheckedItems

                'Insertar Detalle
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "CAT_LotesRemisionesD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_lote", SqlDbType.Int, LotesID)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)


                'Actualizo Boveda
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Bo_BovedaStatusSalida_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Elemento.SubItems(7).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Salida", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoSalida", SqlDbType.Int, TurnoId)

                Cn_Datos.EjecutarNonQueryT(Cmd)

            Next


        Catch ex As Exception
            lc_Transaccion.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False

        End Try

        lc_Transaccion.Commit()
        Cnn.Close()

        Return True


    End Function

#End Region

#Region "Rastreo de remisiones"

    Public Shared Function fn_Rastreo_LlenarImportes(ByRef lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_RemisionesD_GetId", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            lsv.Actualizar(cmd, "Id_Moneda")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarEnvases(ByRef lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Envases_GetByRemision", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            lsv.Actualizar(cmd, "")
            lsv.Columns(0).Text = "Tipo de Envase"
            lsv.Columns(1).Text = "Numero de Envase"
            lsv.Columns(2).Text = "Fecha de Registro"
            lsv.Columns(3).Text = "Hora de Registro"
            lsv.Columns(4).Text = "Usuario de Registro"
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarBoveda(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetRastreo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)

            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarAsignaFyR(ByRef lsv As cp_Listview, ByVal Id_Remision As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_AsignarFechaRuta_GetByRemision", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            lsv.Actualizar(cmd, "Id_Bo")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarProceso(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Pro_Servicios_GetRastreo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)

            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarProDotaciones(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Pro_Dotaciones_GetRastreo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarCajDotaciones(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Caj_Dotaciones_GetRastreo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarMateriales(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Mat_Ventas_GetRastreo", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rastreo_LlenarTraslado(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Remisiones_RastreoRuta", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rastreo_ObtenerAmparada(ByVal Id_Remision As Integer) As DataRow
        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Remisiones_GetAmparada", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

            Dim Tbl As DataTable = EjecutaConsulta(cmd)
            If Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Cambiar Cliente"
    Public Shared Function fn_CambiarCliente_BuscarBoveda(ByVal Id_Remision As Long) As Data.DataRow
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_GetByRemision", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)

        Try
            Dim tbl As Data.DataTable = EjecutaConsulta(cmd)

            If tbl.Rows.Count > 0 Then
                Return tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CambiarCliente_Cambiar(ByVal Id_Remision As Long, ByVal Tipo As Integer, ByVal TipoP As Integer, ByVal EntidadOrigen As Integer, ByVal EntidadDestino As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Boveda_CambiarNombre", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.BigInt, Tipo)
        Crea_Parametro(cmd, "@TipoP", SqlDbType.BigInt, TipoP)
        Crea_Parametro(cmd, "@EntidadOrigen", SqlDbType.BigInt, EntidadOrigen)
        Crea_Parametro(cmd, "@EntidadDestino", SqlDbType.BigInt, EntidadDestino)

        Try
            EjecutarNonQuery(cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CambiarCliente_ActualizarRemision(ByVal Id_Remision As Integer, ByVal ClienteOrigen As Integer, ByVal ClienteDestino As Integer, ByVal Id_ClienteP As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Remisiones_UpdateClientes", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Crea_Parametro(Cmd, "@ClienteOrigen", SqlDbType.Int, ClienteOrigen)
            Crea_Parametro(Cmd, "@ClienteDestino", SqlDbType.Int, ClienteDestino)
            Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)
            EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CambiarCliente_BuscarOrigenDestino(ByVal Id_ClienteP As Integer) As DataRow

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ClientesProceso_GetOrigenDestino", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_ClienteP", SqlDbType.Int, Id_ClienteP)

            Dim dt As DataTable = EjecutaConsulta(Cmd)
            If dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return dt.Rows(0)
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function


#End Region

#Region "Cancelar Envio Proceso"


    Public Shared Function fn_RecLotesBoveda_ValidarNew(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "CAT_LotesRecProceso_Statusvalidar", "@ID_LoteRP")

    End Function

    Public Shared Function fn_CancelarEnvioProceso_LlenarListaNew(ByVal lsv As cp_Listview, ByVal Destino As Char) As Boolean
        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_LotesRecProceso_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Destino", SqlDbType.VarChar, Destino) 'new 26/05/14 depto destino(M=Morralla ó P=Proceso<-default)
            lsv.Actualizar(cmd, "Id_LoteRP")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioProceso_Envases(ByVal Id_Remision As Integer, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get3", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

            lsv.Actualizar(cmd, "Id_Envase")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioProceso_CancelarNew(ByVal lsv As cp_Listview) As Boolean

        'Antes de cancelar falta revisar si la remision en Cat_LotesRecProceso aun sigue en Status='A'

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(Cnn)
        Try

            Dim Realizados As Integer = 0
            Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "Cat_LotesRecProceso_Cancelar")
            For Each Elemento As ListViewItem In lsv.CheckedItems
                Cmd.Parameters.Clear()
                Crea_Parametro(Cmd, "@Id_LoteRP", SqlDbType.Int, Elemento.Tag)
                Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
                Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

                If EjecutarNonQueryT(Cmd) > 0 Then Realizados += 1
            Next
            If Realizados = lsv.CheckedItems.Count Then
                tr.Commit()
                Cnn.Close()
                Return True
            Else
                tr.Rollback()
                Cnn.Close()
                Return False
            End If
        Catch ex As Exception
            tr.Rollback()
            Cnn.Close()
            Return False
            TrataEx(ex, False)
        End Try
    End Function

    '--estas 3 funciones son de CancelarEnvioaProceso Antes
    Public Shared Function fn_CancelarEnvioProceso_LlenarLista(ByVal lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("CAT_LotesRemisiones_GETGnr", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Tipo_Lote", SqlDbType.Int, 1)

            lsv.Actualizar(cmd, "Id_Lote")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioProceso_LlenarDetalles(ByVal lsv As cp_Listview, ByVal Id_Lote As Integer) As Boolean
        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_LotesRemisionesD_GetServicios", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@ID_Lote", SqlDbType.Int, Id_Lote)

            lsv.Actualizar(cmd, "Id_Remision")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioProceso_Cancelar(ByVal Id_Lotes() As Integer) As Boolean
        For Each Lote As Integer In Id_Lotes
            Try
                Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_LotesRemisiones_Cancelar", CommandType.StoredProcedure, Crea_ConexionSTD)
                Crea_Parametro(cmd, "@Id_Lote", SqlDbType.Int, Lote)
                Crea_Parametro(cmd, "@Usuario", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

                EjecutarNonQuery(cmd)
            Catch ex As Exception
                TrataEx(ex)
            End Try
        Next

        Return True
    End Function


#End Region

#Region "Cancelar Envio Auditoria"

    Public Shared Function fn_CancelarEnvioAuditoria_LlenarLista(ByVal lsv As cp_Listview) As Boolean
        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("CAT_LotesRemisiones_GETGnr", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Tipo_Lote", SqlDbType.Int, 53)

            lsv.Actualizar(cmd, "Id_Lote")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioAuditoria_LlenarDetalles(ByVal lsv As cp_Listview, ByVal Id_Lote As Integer) As Boolean
        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_LotesRemisionesD_GetCajeros", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@ID_Lote", SqlDbType.Int, Id_Lote)

            lsv.Actualizar(cmd, "Id_Remision")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioAuditoria_Cancelar(ByVal Id_Lotes() As Integer) As Boolean
        For Each Lote As Integer In Id_Lotes
            Try
                Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_LotesRemisiones_Cancelar", CommandType.StoredProcedure, Crea_ConexionSTD)
                Crea_Parametro(cmd, "@Id_Lote", SqlDbType.Int, Lote)
                Crea_Parametro(cmd, "@Usuario", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

                EjecutarNonQuery(cmd)
            Catch ex As Exception
                TrataEx(ex)
            End Try
        Next

        Return True
    End Function

#End Region

#Region "Cancelar Envio Cajeros"

    Public Shared Function fn_CancelarEnvioCajeros_LlenarListaRemanentes(ByVal lsv As cp_Listview) As Boolean

        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("CAT_LotesRemisiones_GETGnr", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(cmd, "@Tipo_Lote", SqlDbType.Int, 39)

            lsv.Actualizar(cmd, "Id_Lote")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioCajeros_LlenarListaDotaciones(ByVal lsv As cp_Listview) As Boolean

        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("CAT_LotesRemisiones_GETGnr", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(cmd, "@Tipo_Lote", SqlDbType.Int, 21)

            lsv.Actualizar(cmd, "Id_Lote")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioCajeros_LlenarListaDotacionesAuditoria(ByVal lsv As cp_Listview) As Boolean

        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("CAT_LotesRemisiones_GETGnr", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(cmd, "@Tipo_Lote", SqlDbType.Int, 53)

            lsv.Actualizar(cmd, "Id_Lote")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioCajeros_LlenarDetalles(ByVal lsv As cp_Listview, ByVal Id_Lote As Integer) As Boolean
        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_LotesRemisionesD_GetCajeros", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@ID_Lote", SqlDbType.Int, Id_Lote)

            lsv.Actualizar(cmd, "Id_Remision")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    'Public Shared Function fn_CancelarEnvioCajeros_Cancelar2(ByVal Id_Lotes() As Integer) As Boolean
    '    For Each Lote As Integer In Id_Lotes
    '        Try
    '            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_LotesRemisiones_Cancelar", CommandType.StoredProcedure, Crea_ConexionSTD)
    '            Crea_Parametro(cmd, "@Id_Lote", SqlDbType.Int, Lote)
    '            Crea_Parametro(cmd, "@Usuario", SqlDbType.Int, UsuarioId)
    '            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

    '            EjecutarNonQuery(cmd)
    '        Catch ex As Exception
    '            TrataEx(ex)
    '        End Try
    '    Next

    '    Return True
    'End Function

    Public Shared Function fn_CancelarEnvioCajeros_Cancelar(ByVal lsv As cp_Listview) As Boolean
        For Each Elemento As ListViewItem In lsv.CheckedItems
            Try
                Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_LotesRemisiones_Cancelar", CommandType.StoredProcedure, Crea_ConexionSTD)
                Crea_Parametro(cmd, "@Id_Lote", SqlDbType.Int, Elemento.Tag)
                Crea_Parametro(cmd, "@Usuario", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)

                EjecutarNonQuery(cmd)
            Catch ex As Exception
                TrataEx(ex)
            End Try
        Next

        Return True
    End Function

#End Region

#Region "Cancelar Despachos"

    Public Shared Function fn_CancelarDespacho_LlenarLista(ByVal lsv As cp_Listview, ByVal Tipo As Integer) As Boolean

        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Despacho_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(cmd, "@FDesde", SqlDbType.Date, Today.Date)
            Cn_Datos.Crea_Parametro(cmd, "@FHasta", SqlDbType.Date, Today.Date)
            Cn_Datos.Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)
            Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(cmd, "@Dpto_Despacho", SqlDbType.VarChar, BovedaTipo)

            lsv.Actualizar(cmd, "Id_Despacho")
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(10).Width = 100

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarDespacho_LlenarDetalles(ByVal lsv As cp_Listview, ByVal Id_Despacho As Integer) As Boolean
        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_DespachoD_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)

            lsv.Actualizar(cmd, "Id_Remision")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CancelarDespacho_Cancelar(ByVal Id_Despacho As Integer) As Boolean
        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Despacho_Reversa", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
            Crea_Parametro(cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Tipo_Cancela", SqlDbType.Int, 2)

            EjecutarNonQuery(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_CancelarDespacho_Manual(ByVal Id_Despacho As Integer, ByVal Interno As Boolean, ByVal Pendiente As Boolean) As Boolean
        Dim Cnn As SqlClient.SqlConnection
        Dim Tr As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Cantidad As Integer = 0
        Try
            Cnn = Crea_ConexionSTD()
            Tr = crear_Trans(Cnn)

            'Cancelar el Registro del Despacho
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Bo_Despacho_Cancelar")
            Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
            Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Tipo_Cancela", SqlDbType.Int, 2)
            Cantidad = EjecutarNonQueryT(Cmd)

            'Regresar las Remisiones al Saldo de Bóveda
            Cmd.Parameters.Clear()
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Bo_Boveda_CancelarDespacho")
            Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
            Cantidad += EjecutarNonQueryT(Cmd)

            If Interno And Not Pendiente Then
                'Si es un Despacho de Rutas propias y el despacho ya no está como Pendiente
                'Eliminar las Remisiones de los Puntos en Ruta
                Cmd.Parameters.Clear()
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Bo_Despacho_CancelarPuntos")
                Crea_Parametro(Cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
                Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
                Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)

                Cantidad += EjecutarNonQueryT(Cmd)
            End If
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
        Tr.Commit()
        Cmd.Dispose()
        Return True
    End Function

    Public Shared Function fn_CancelarDespacho_CancelarPuntos(ByVal Id_Despacho As Integer) As Boolean
        Try
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Despacho_CancelarPuntos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
            Crea_Parametro(cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)

            EjecutarNonQuery(cmd)
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

#End Region

#Region "Comprobar Remisión"

    Public Shared Function fn_ComprobarRemision_ObtenerID(ByVal Numero_Remision As Int64, ByVal Id_Cia As Integer) As DataRow
        Dim dt As DataTable
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Cat_RemisionesBoveda_Get", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, Numero_Remision)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "T")

            dt = EjecutaConsulta(Cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_ComprobarRemision_RemisionesD(ByVal Id_Remision As Integer) As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_RemisionesD_GetId", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Tbl.Columns(2).ReadOnly = False
                Tbl.Columns(3).ReadOnly = False
                Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ComprobarRemision_Update(ByVal Id_Remision As Integer, ByVal Id_Cia As Integer, ByVal Id_CiaProp As Integer, _
                                                   ByVal Envases As Integer, ByVal EnvasesSN As Integer, ByVal Importe As Decimal, _
                                                   ByVal dt As DataTable, ByVal lsv As ListView, ByVal HoraRemision As String) As Boolean
        Dim Elemento As ListViewItem
        Dim Rutas As Integer = 0

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim trans As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand

        Try
            'Actualizar Cat_Remisiones
            Cmd = Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_Remisiones_Update")
            Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            Crea_Parametro(Cmd, "@Id_CiaProp", SqlDbType.Int, Id_CiaProp)
            Crea_Parametro(Cmd, "@Envases", SqlDbType.Int, Envases)
            Crea_Parametro(Cmd, "@EnvasesSN", SqlDbType.Int, EnvasesSN)
            Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
            Crea_Parametro(Cmd, "@Hora_Remision", SqlDbType.VarChar, HoraRemision)
            EjecutarNonQueryT(Cmd)

            For Each lc_dr As DataRow In dt.Rows
                Cmd = Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "CAT_RemisionesD_Update")
                Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                Crea_Parametro(Cmd, "@Id_Moneda", SqlDbType.Int, CInt(lc_dr("Id_Moneda")))
                Crea_Parametro(Cmd, "@Importe_Efectivo", SqlDbType.Money, CDec(lc_dr(2)))
                Crea_Parametro(Cmd, "@Importe_Documentos", SqlDbType.Money, CDec(lc_dr(3)))
                EjecutarNonQueryT(Cmd)
            Next

            For Each Elemento In lsv.Items
                If Elemento.Tag = 0 Then
                    Cmd = Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "CAT_Envases_Create")
                    Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
                    Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, Elemento.SubItems(2).Text)
                    Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                    Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    EjecutarNonQueryT(Cmd)
                Else
                    Cmd = Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_Envases_Update")
                    Crea_Parametro(Cmd, "@Id_Envase", SqlDbType.Int, CInt(Elemento.Tag))
                    Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Elemento.SubItems(1).Text)
                    Crea_Parametro(Cmd, "@Id_TipoE", SqlDbType.Int, Elemento.SubItems(2).Text)
                    EjecutarNonQueryT(Cmd)
                End If
            Next

            trans.Commit()
            Cnn.Close()
            Return True

        Catch ex As Exception
            trans.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ComprobarRemision_LlenarEnvases(ByVal Id_Remision As Long) As DataTable

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Envases_Get4", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, Id_Remision)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_ComprobarRemision_BorrarEnvase(ByVal Id_Envase As Integer) As Boolean
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand

            Cmd = Crea_Comando("Cat_Envases_DeleteById", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Envase", SqlDbType.Int, Id_Envase)
            EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "Capturar Anomalías en Envases"

    Public Shared Function fn_AnomaliasEnvases_ObtenerDatos(ByVal Id_Remision As Integer) As DataRow
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("TV_Programacion_GetTripulacion", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
        Try
            Dim Tbl As DataTable = EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_AnomaliasEnvases_ObtenerCustodios(ByVal Id_Programacion As Integer, ByVal LSV As cp_Listview) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("TV_ProgramacionCus_GetById", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
        Try
            LSV.Actualizar(Cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_AnomaliasEnvases_GuardarActa(ByVal Id_Remision As Integer, ByVal Id_Punto As Integer, ByVal Fecha_Acta As Date, _
                                                           ByVal Hora_Acta As String, ByVal Numero_Esclusa As Integer, ByVal Id_Cliente As Integer, _
                                                           ByVal Motivo_Acta As String, ByVal Observaciones As String) As Integer

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Actas_Create", CommandType.StoredProcedure, Cnn)

        Try
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)
            Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Id_Punto)
            Crea_Parametro(Cmd, "@Fecha_Acta", SqlDbType.Date, Fecha_Acta)
            Crea_Parametro(Cmd, "@Hora_Acta", SqlDbType.Time, Hora_Acta)
            Crea_Parametro(Cmd, "@Numero_Esclusa", SqlDbType.Int, Numero_Esclusa)
            Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(Cmd, "@Motivo_Acta", SqlDbType.VarChar, Motivo_Acta)
            Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

            Return EjecutarScalar(Cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_AnomaliasEnvases_MostrarActa(ByVal Id_Acta As Integer, ByVal Id_Remision As Integer, ByVal Id_Programacion As Integer) As Boolean
        'Aqui se imprime el Acta
        Dim frm As New frm_Acta
        Dim rpt As New rpt_ActaRecepcion
        Dim ds As New ds_ActaRecepcion

        fn_AnomaliasEnvases_Logo(ds.Cat_Sucursales_GetDatos)
        fn_AnomaliasEnvases_Acta(ds.Cat_Actas_ReporteGet, Id_Acta)
        fn_AnomaliasEnvases_ObtenerEnvases(ds.Cat_Envases_Get4, Id_Remision)
        fn_AnomaliasEnvases_LlenarCustodios(ds.Custodios, Id_Programacion)
        fn_AnomaliasEnvases_ObtenerTripulacion(ds.Tripulación, Id_Programacion)

        rpt.SetDataSource(ds)

        frm.crv_Acta.ReportSource = rpt

        frm.ShowDialog()

    End Function

    Public Shared Function fn_AnomaliasEnvases_Logo(ByRef Tabla As ds_ActaRecepcion.Cat_Sucursales_GetDatosDataTable) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AnomaliasEnvases_Acta(ByRef Tabla As ds_ActaRecepcion.Cat_Actas_ReporteGetDataTable, ByVal Id_Acta As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Actas_ReporteGet", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Acta", SqlDbType.Int, Id_Acta)

        Try
            cmd.Connection.Open()
            Tabla.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AnomaliasEnvases_ObtenerEnvases(ByVal Tabla As ds_ActaRecepcion.Cat_Envases_Get4DataTable, ByVal Id_Remision As Long) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Envases_Get4", CommandType.StoredProcedure, Cnn)

        Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

        Try
            Cmd.Connection.Open()
            Tabla.Load(Cmd.ExecuteReader)
            Cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_AnomaliasEnvases_LlenarCustodios(ByVal Tabla As ds_ActaRecepcion.CustodiosDataTable, ByVal Id_Programacion As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("TV_ProgramacionCus_GetById", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
        Try
            Cmd.Connection.Open()
            Tabla.Load(Cmd.ExecuteReader)
            Cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AnomaliasEnvases_ObtenerTripulacion(ByVal Tabla As ds_ActaRecepcion.TripulaciónDataTable, ByVal Id_Programacion As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("TV_Programacion_GetXID", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
        Try
            Cmd.Connection.Open()
            Tabla.Load(Cmd.ExecuteReader)
            Cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Consulta de Apertura y Cierres de Boveda"
    Public Shared Function fn_ConsultaAperturasCierres_LlenarLista(ByVal Id_Boveda As Integer, ByVal FechaInicio As DateTime, ByVal FechaFin As DateTime, ByVal lsv As cp_Listview) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_AperturaCierre_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Try
            Crea_Parametro(cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
            Crea_Parametro(cmd, "@FechaInicio", SqlDbType.DateTime, FechaInicio)
            Crea_Parametro(cmd, "@FechaFin", SqlDbType.DateTime, FechaFin)

            lsv.Actualizar(cmd, "Id_AperturaCierre")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right

            lsv.Columns(6).Width = 0
            lsv.Columns(7).Width = 0
            lsv.Columns(8).Width = 0
            lsv.Columns(9).Width = 0
            lsv.Columns(10).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "Consulta de Actas de Anomalías en Remisiones"

    Public Shared Function fn_ConsultaActasAnomalias_LlenarLista(ByVal FechaInicio As DateTime, ByVal FechaFin As DateTime, ByVal lsv As cp_Listview, ByVal NumeroRemision As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand
        Try
            If NumeroRemision = 0 Then
                cmd = Crea_Comando("Cat_Actas_GetByFechas", CommandType.StoredProcedure, Crea_ConexionSTD)
                Crea_Parametro(cmd, "@FechaInicio", SqlDbType.DateTime, FechaInicio)
                Crea_Parametro(cmd, "@FechaFin", SqlDbType.DateTime, FechaFin)
            Else
                cmd = Crea_Comando("Cat_Actas_GetByRemision", CommandType.StoredProcedure, Crea_ConexionSTD)
                Crea_Parametro(cmd, "@NumeroRemision", SqlDbType.Int, NumeroRemision)
                Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, CiaId)
            End If

            lsv.Actualizar(cmd, "Id_Acta")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Pernoctas"

    Public Shared Function fn_Pernoctas_LlenarListas(ByVal Desde As Date, ByVal Hasta As Date, ByVal Status As Char, ByVal Id_Cliente As Integer, ByVal TipoConsulta As Short, ByRef lsv As cp_Listview) As Boolean
        Try
            'Tipos:
            '1 = Custodia
            '2 = Proceso
            Dim Tipo_Consulta As Integer
            Dim TipoP_Consulta As Integer

            If TipoConsulta = 1 Then
                Tipo_Consulta = 1
                TipoP_Consulta = 0
            Else
                Tipo_Consulta = 2
                TipoP_Consulta = 1
            End If

            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Bo_Boveda_Pernoctas", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
            Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo_Consulta)
            Crea_Parametro(cmd, "@TipoP", SqlDbType.Int, TipoP_Consulta)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@TipoConsulta", SqlDbType.TinyInt, TipoConsulta)

            lsv.Actualizar(cmd, "Id_Remision")
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right

            For Each Elemento As ListViewItem In lsv.Items
                'Si la remision trae Id_Pernocta se pone de color azul.
                If CInt(Elemento.SubItems(9).Text) <> 0 Then Elemento.ForeColor = System.Drawing.Color.Blue
            Next
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Pernoctas_Guardar(ByVal InicioPernocta As Date, ByVal FinPernocta As Date, ByVal Id_Cliente As Integer, ByVal Id_CS As Integer, ByVal Observaciones As String, ByVal lsv As cp_Listview) As Boolean
        Dim Creados As Integer = 0
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tran As SqlTransaction = crear_Trans(cnn)
        Try
            Dim cmd As SqlCommand = Crea_ComandoT(cnn, tran, CommandType.StoredProcedure, "Bo_Pernoctas_Create")

            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, 0)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
            Crea_Parametro(cmd, "@Miles", SqlDbType.Decimal, 0.0)
            Crea_Parametro(cmd, "@Fecha", SqlDbType.Date, Now.Date)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Observaciones_Registro", SqlDbType.VarChar, Observaciones)

            For Each Elemento As ListViewItem In lsv.CheckedItems
                For Fecha As Integer = 0 To DateDiff(DateInterval.Day, InicioPernocta, FinPernocta)
                    cmd.Parameters("@Id_Remision").Value = Elemento.Tag
                    cmd.Parameters("@Fecha").Value = DateAdd(DateInterval.Day, Fecha, InicioPernocta)

                    If (CDec(Elemento.SubItems(5).Text) Mod 1000) = 0 Then
                        cmd.Parameters("@Miles").Value = Elemento.SubItems(5).Text \ 1000
                    Else
                        If (CDec(Elemento.SubItems(5).Text) Mod 1000) >= 999.5 Then
                            cmd.Parameters("@Miles").Value = Elemento.SubItems(5).Text \ 1000
                        Else
                            cmd.Parameters("@Miles").Value = (Elemento.SubItems(5).Text \ 1000) + 1
                        End If
                    End If

                    EjecutarNonQueryT(cmd)
                    Creados += 1
                Next
            Next

            If Creados > 0 Then
                tran.Commit()
                cnn.Close()
                Return True
            Else
                tran.Rollback()
                cnn.Close()
                Return False
            End If
        Catch ex As Exception
            tran.Rollback()
            cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Pernoctas_LlenarPercnotas(ByVal Id_Remision As Integer, ByVal lsv As cp_Listview) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Bo_Pernoctas_Get", CommandType.StoredProcedure, cnn)

            Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, Id_Remision)

            lsv.Actualizar(cmd, "Id_Pernocta")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Pernoctas_Eliminar(ByVal Id_Pernocta As Integer) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Bo_Pernoctas_Delete", CommandType.StoredProcedure, cnn)

            Crea_Parametro(cmd, "@Id_Pernocta", SqlDbType.Int, Id_Pernocta)

            If EjecutarNonQuery(cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Pernoctas_Actualizar(ByVal Id_Pernocta As Integer, ByVal Fecha As Date, ByVal Id_CS As Integer, ByVal Miles As Decimal, ByVal Observaciones As String) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Bo_Pernoctas_Update", CommandType.StoredProcedure, cnn)

            Crea_Parametro(cmd, "@Id_Pernocta", SqlDbType.Int, Id_Pernocta)
            Crea_Parametro(cmd, "@Id_CS", SqlDbType.Int, Id_CS)
            Crea_Parametro(cmd, "@Miles", SqlDbType.Decimal, Miles)
            Crea_Parametro(cmd, "@Fecha", SqlDbType.Date, Fecha)
            Crea_Parametro(cmd, "@Observaciones_Registro", SqlDbType.VarChar, Observaciones)

            If EjecutarNonQuery(cmd) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Consulta de Despachos"

    Public Shared Function fn_ConsultarDespacho_LlenarLista(ByVal lsv As cp_Listview, ByVal Desde As Date, ByVal Hasta As Date, ByVal Id_Cia As Integer, ByVal Id_Ruta As Integer, ByVal Usuario_Despacho As Integer, ByVal Status As String) As Boolean

        Try
            Dim cmd As SqlCommand = Crea_Comando("Bo_Despacho_Get2", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@FDesde", SqlDbType.Date, Desde)
            Crea_Parametro(cmd, "@FHasta", SqlDbType.Date, Hasta)
            Crea_Parametro(cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            Crea_Parametro(cmd, "@Id_Ruta", SqlDbType.Int, Id_Ruta)
            Crea_Parametro(cmd, "@Usuario_Despacho", SqlDbType.Int, Usuario_Despacho)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@Dpto_Despacho", SqlDbType.VarChar, BovedaTipo)

            lsv.Actualizar(cmd, "Id_Despacho")
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

    'Carlos sola 19/09/12
#Region "VALIDAR SESION"

    Public Shared Function GetSession() As Integer
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Pro_Sesion_GetActiva", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Tipo_Sesion", SqlDbType.TinyInt, 0)
        Try
            Return EjecutarScalar(cmd)
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return 0
        End Try
    End Function

#End Region
    'Carlos Sola 19/09/12

#Region "Descargar Archivos"

    Public Shared Function fn_Archivos_Descargar(ByVal Id_Doc As Integer) As Byte()
        Dim dt As DataTable
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Doc", SqlDbType.Int, Id_Doc)

        Try
            dt = Cn_Datos.EjecutaConsulta(Cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)("Archivo")
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_ModulosArchivos_LlenarLista(ByRef lsv As cp_Listview, ByVal Clave_Modulo As String) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, Clave_Modulo)
        Try
            lsv.Actualizar(Cmd, "Id_Doc")
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, True)
            Return False
        End Try
    End Function

#End Region

#Region "Remisiones Rechazadas Rutas Externas"

    Public Shared Function fn_Guarada_RemisionesRechazadas(ByVal Id_Cia As Integer, ByVal NumeroRemision As Long, ByVal CantidadEnvases As Integer, _
                                                          ByVal ImporteTotal As Decimal, ByVal Observaciones As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Bo_Rechazos_Create", CommandType.StoredProcedure, Cnn)
        Try
            Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, NumeroRemision)
            Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, CantidadEnvases)
            Crea_Parametro(Cmd, "@Importe_Total", SqlDbType.Money, ImporteTotal)
            Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)
            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Consultar_RemisionesRechazadas(ByVal Bo_NumeroRemision As Long, ByVal Id_Cia As Integer) As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Bo_Rechazos_Existe", CommandType.StoredProcedure, Cnn)
        Try
            Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.BigInt, Bo_NumeroRemision)
            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Actualizar_RemisionesRechazadas(ByVal Id_Rechazo As Integer, ByVal UsuarioAutoriza As Integer, ByVal Observaciones As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Bo_Rechazos_Update", CommandType.StoredProcedure, Cnn)
        Try
            Crea_Parametro(Cmd, "@Id_Rechazo", SqlDbType.Int, Id_Rechazo)
            Crea_Parametro(Cmd, "@Observaciones_Autoriza", SqlDbType.VarChar, Observaciones)
            Crea_Parametro(Cmd, "@Estacion_Autoriza", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@Usuario_Autoriza", SqlDbType.Int, UsuarioAutoriza)

            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaRemisionesRechazadas(ByVal lsv As cp_Listview, ByVal Id_Cia As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Bo_Rechazos_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Cia", SqlDbType.Int, Id_Cia)
            Crea_Parametro(Cmd, "@Fecha_Desde", SqlDbType.Date, Desde)
            Crea_Parametro(Cmd, "@Fecha_Hasta", SqlDbType.Date, Hasta)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Rechazo")
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right

            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "FUNCION CUENTA SETTINGS"

    Public Shared Function fn_CuentaSettings() As Integer
        Dim CuentaSettings As Integer = 0
        For Each setting As System.Configuration.SettingsProperty In My.Settings.Properties
            If Microsoft.VisualBasic.Left(setting.Name.ToString.ToUpper, 9) = "SERVDATOS" AndAlso (My.Settings(setting.Name)).ToString.Split(",")(0) = "VACIO" Then
                CuentaSettings += 1
            End If
        Next
        Return CuentaSettings
    End Function

#End Region

#Region "Bovedas"

    Public Shared Function fn_Bovedas_Catalogo_LlenarLista(ByVal Lista As cp_Listview, ByVal Tipo As String) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Bovedas_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.VarChar, Tipo)

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, "Id_Boveda")
            Lista.Columns(5).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_Catalogo_ObtenValores(ByVal Id As Integer) As DataRow

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Bovedas_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id)
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

    Public Shared Function fn_Bovedas_Catalogo_ValidarClave(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean
        If ClaveAnt = "" Then GoTo Validar
        If Not Clave = ClaveAnt Then GoTo Validar
        Return True
        Exit Function
Validar:
        Return fn_ValidarClave(Clave, "@Clave_Boveda", "Cat_BovedasClave_Read")

    End Function

    Public Shared Function fn_Bovedas_Catalogo_Nuevo(ByVal Clave As String, ByVal Descripcion As String, ByVal Apertura As String, _
                                             ByVal Cierre As String, ByVal MonedaLR As Integer, ByVal ImporteLR _
                                             As Integer, ByVal Tipo As Char) As Boolean

        'Aqui se inserta un nuevo registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Bovedas_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Boveda", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Hora_Apertura", SqlDbType.VarChar, Apertura)
        Cn_Datos.Crea_Parametro(Cmd, "@Hora_Cierre", SqlDbType.VarChar, Cierre)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_LR", SqlDbType.Int, MonedaLR)
        Cn_Datos.Crea_Parametro(Cmd, "@Importe_LR", SqlDbType.Int, ImporteLR)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, Tipo)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Bovedas_Catalogo_Actualizar(ByVal Id As Integer, ByVal Clave As String, ByVal Descripcion As String, ByVal Apertura As String, _
                                             ByVal Cierre As String, ByVal MonedaLR As Integer, ByVal ImporteLR _
                                             As Integer, ByVal Tipo As Char) As Boolean

        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Bovedas_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Boveda", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Hora_Apertura", SqlDbType.VarChar, Apertura)
        Cn_Datos.Crea_Parametro(Cmd, "@Hora_Cierre", SqlDbType.VarChar, Cierre)
        Cn_Datos.Crea_Parametro(Cmd, "@Moneda_LR", SqlDbType.Int, MonedaLR)
        Cn_Datos.Crea_Parametro(Cmd, "@Importe_LR", SqlDbType.Int, ImporteLR)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, Tipo)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Bovedas_Catalogo_BajaAlta(ByVal Id As Integer, ByVal Status As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Bovedas_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Bovedas_Catalogo_ValidarDependencias(ByVal Id As Integer) As Boolean

        Return fn_ValidarDependencias(Id, "Cat_Bovedas_Dependencias", "@Id_Boveda")

    End Function

#End Region

#Region "VitacoraCabiosRuta"

    Public Shared Function Fn_MostrarVitacora(ByVal Lsv As cp_Listview, ByVal Numero_Remision As Integer, ByVal F_Desde As Date, ByVal F_Hasta As Date) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Bo_AsignarFechaRuta_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Remision", SqlDbType.Int, Numero_Remision)
        Crea_Parametro(Cmd, "@F_Desde", SqlDbType.Date, F_Desde)
        Crea_Parametro(Cmd, "@F_Hasta", SqlDbType.Date, F_Hasta)
        Try
            Lsv.Actualizar(Cmd, "")
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try


    End Function

#End Region

#Region "Servicios Cambio de Boveda"

    Public Shared Function fn_Bo_BovedaLlenaListaServicios(ByVal lsv As cp_Listview, ByVal Id_Boveda As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand
            Cmd = Cn_Datos.Crea_Comando("Bo_Boveda_GetId_Boveda", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_Boveda)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")


            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Bo")

            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(1).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            'lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Bo_BovedaCambioBovedaServicio(ByVal lsv As cp_Listview, ByVal Id_BovedaDestino As Integer) As Boolean

        Try

            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand

            For Each Elem As ListViewItem In lsv.CheckedItems
                Cmd = Cn_Datos.Crea_Comando("Bo_Boveda_Update", CommandType.StoredProcedure, Cnn)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Int, Elem.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, Id_BovedaDestino)

                EjecutarNonQuery(Cmd)
            Next
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try


    End Function


#End Region

#Region " 11 agosto 2014-Recepcion de Rutas Propias Pestaña/Remisiones"
    Public Shared Function fn_RecRutasPropias_GuardarXRemision(ByVal ID_Boveda As Integer, ByVal ID_Programacion As Integer, ByVal Lsv_Remisiones As cp_Listview, ByVal Fecha As Date, ByVal Id_Ruta As Integer) As Integer

        'Cambia estatus las Remisiones e inserta en Boveda
        Dim CT As Integer = fn_RecRutasPropias_statusRemisiones(ID_Boveda, ID_Programacion, Lsv_Remisiones, Id_Ruta)
        If CT = -1 Then Return CT

        If CT > 0 Then
            'En esta parte guarda los movimientos
            If Not fn_RecRutasPropias_GuardaMovimientos(ID_Programacion, Fecha, Id_Ruta) Then
                Return -2
            End If
        End If

        Return CT

    End Function

    Public Shared Function fn_RecRutasPropias_statusRemisiones(ByVal BovedaID As Integer, ByVal ID_Programacion As Integer, ByVal Lsv_Remisiones As ListView, ByVal Id_Ruta As Integer) As Integer

        Dim cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Ct As Integer = 0 'ComprobantesTraslado
        Dim Tipo As Integer = 1
        Dim TipoP As Integer = 0
        Dim Entidad_Origen As Integer = 0
        Dim Entidad_Destino As Integer = 0
        Tr = crear_Trans(cnn)
        Try
            'Recorrer el lsv de puntos --->
            For Each ElementoRem As ListViewItem In Lsv_Remisiones.Items
                Entidad_Origen = CInt(ElementoRem.SubItems(14).Text) 'CO
                Entidad_Destino = CInt(ElementoRem.SubItems(15).Text) 'CD

                Tipo = 1 : TipoP = 0 '[Custodia]
                '18=IDCP, 19=IDCB, 20=IDCB2, 21=STCP
                If CInt(ElementoRem.SubItems(18).Text) > 0 AndAlso (CInt(ElementoRem.SubItems(19).Text) = CInt(ElementoRem.SubItems(20).Text)) AndAlso ElementoRem.SubItems(21).Text = "A" Then
                    'Si el Cliente Origen es un cliente de proceso y su caja bancaria es igual al cliente destino y esta activo, entonces es para pr0ceso
                    Tipo = 2 : TipoP = 1
                    Entidad_Origen = CInt(ElementoRem.SubItems(18).Text)
                    Entidad_Destino = 0
                End If

                If ElementoRem.SubItems(16).Text = "EN" Then
                    'Solo evalua los de Boveda
                    If ElementoRem.SubItems(8).Text <> "" Then
                        If Microsoft.VisualBasic.Left(ElementoRem.SubItems(8).Text, 1) = "B" Then
                            'tv puntos remisiones marcar RR
                            If ElementoRem.SubItems(5).Text = "MARCADO PARA REGRESAR" Then
                                'La Remisión no se entregó al destino Final, se tiene que regresar a Bóveda
                                'Si la Remisión viene con status R se actualiza a RR y se regresa a Bo_Boveda.Status='A'
                                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Bo_Boveda_Status")
                                Cn_Datos.Crea_Parametro(Cmd, "@ID_Remision", SqlDbType.BigInt, CInt(ElementoRem.Tag.ToString))
                                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                                Cn_Datos.EjecutarNonQueryT(Cmd)

                                'tv puntos remisiones marcar RR
                                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "TV_PuntosRemisiones_StatusRR")
                                Cn_Datos.Crea_Parametro(Cmd, "@ID_Remision", SqlDbType.BigInt, CInt(ElementoRem.Tag.ToString))
                                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
                                Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Valida", SqlDbType.VarChar, "B")
                                Cn_Datos.EjecutarNonQueryT(Cmd)
                                Ct += 1
                            End If
                        End If ' fin 'B'
                    End If
                End If

                'En Ruta
                If ElementoRem.SubItems(16).Text = "RU" Then
                    If ElementoRem.SubItems(8).Text <> "" Then
                        'Solo evalua los de Boveda
                        If Microsoft.VisualBasic.Left(ElementoRem.SubItems(8).Text, 1) = "B" Then
                            If ElementoRem.SubItems(5).Text = "VALIDADO" Then
                                'Inserta En Bo_Boveda
                                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "BO_Boveda_Create")
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_Boveda", SqlDbType.Int, BovedaID)
                                Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
                                Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, TipoP)
                                Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Origen", SqlDbType.Int, Entidad_Origen)
                                Cn_Datos.Crea_Parametro(Cmd, "@Entidad_Destino", SqlDbType.Int, Entidad_Destino)
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_TurnoEntrada", SqlDbType.Int, TurnoId)
                                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, CLng(ElementoRem.Tag.ToString))
                                Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Entrada", SqlDbType.Int, Id_Ruta)
                                Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, 0)
                                Cn_Datos.Crea_Parametro(Cmd, "@Horario_Entrega", SqlDbType.VarChar, "")
                                Cn_Datos.Crea_Parametro(Cmd, "@DotacionPro", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@DotacionMorr", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@DotacionATM", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@DotacionNom", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@ConcentracionATM", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@CustodiaATM", SqlDbType.VarChar, "N")
                                Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "B")

                                Cn_Datos.EjecutarNonQueryT(Cmd)

                                'Actualiza Remision. Dentro de este procedimiento tambien se le cambia el Status al Punto
                                'cuando ya no hay remisiones por afectar
                                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "TV_PuntosRemisiones_RB")
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.BigInt, ElementoRem.SubItems(13).Text)
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.BigInt, CLng(ElementoRem.Tag.ToString))
                                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "RB")

                                Cn_Datos.EjecutarNonQueryT(Cmd)

                                'If ElementoRem.SubItems(1).Tag.ToString() = "1" Then
                                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Kardex_CasetUpdateRutaInicio")
                                Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.BigInt, CInt(ElementoRem.SubItems(14).Text))
                                Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Inicio", SqlDbType.VarChar, "N")
                                Cn_Datos.EjecutarNonQueryT(Cmd)
                                'ElementoRem.SubItems(1).Tag = 0 ' asignarle un valor false, para que en la siguiente pasada no entre.
                                'End If
                                Ct += 1
                            End If
                        End If ' 'B'
                    End If
                End If
            Next 'Remisiones

        Catch ex As Exception
            Tr.Rollback()
            cnn.Close()
            TrataEx(ex)
            Return -1
        End Try

        Tr.Commit()
        cnn.Close()
        Return Ct

    End Function

    Public Shared Function fn_RecRutasPropias_GuardaMovimientos(ByVal ID_Programacion As Integer, ByVal Fecha As Date, ByVal Id_Ruta As Integer) As Boolean

        'Revisar que todos los puntos tengan su movimiento
        'y cuando no lo tengan se debe insertar uno
        Dim cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Dt_Remisiones As DataTable
        Dim Dt_Movimientos As DataTable
        Dim Dt_Datos As DataTable
        Dim Dt_RemisionesD As DataTable
        '
        'Datos para el Movimiento
        Dim Id_Movimiento As Integer = 0
        Dim Id_Cliente As Integer
        Dim Id_CS As Integer
        Dim Id_Precio As Integer
        Dim Id_CR As Integer
        Dim Id_EE As Integer
        Dim Id_KM As Integer
        Dim Cantidad_Remisiones As Integer
        Dim Cantidad_Envases As Integer
        Dim Envases_Exceso As Integer
        Dim Importe As Decimal
        Dim Importe_Efectivo As Decimal
        Dim Importe_Documentos As Decimal
        Dim Miles As Decimal
        Dim Dt_Puntos As DataTable
        Dim TipoTV As Byte

        Dim HayCR As Boolean
        Dim Cobra_Doctos As String
        Dim Redondeado As String
        Dim CantidadXunidad As Integer
        Dim MilesSinCosto As Integer

        Dim HayKM As Boolean
        Dim CantidadKM As Integer
        Dim Movimiento_Verificado As Integer
        Tr = crear_Trans(cnn)
        Try
            'Consultar todos los Puntos de la Ruta 
            Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Tv_Puntos_ReadTodos")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_Programacion)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "RB")

            Dt_Puntos = Cn_Datos.EjecutaConsultaT(Cmd)

            'Recorrer el dt_puntos 
            For Each Punto As DataRow In Dt_Puntos.Rows
                Cantidad_Envases = 0
                Cantidad_Remisiones = 0
                Importe_Efectivo = 0
                Importe_Documentos = 0
                Importe = 0
                Miles = 0
                Id_CS = 0
                Id_CR = 0
                Id_KM = 0
                Id_EE = 0
                Id_Precio = 0
                Id_Movimiento = 0
                Movimiento_Verificado = 0
                HayCR = False
                Cobra_Doctos = "N"
                Redondeado = "S"
                CantidadXunidad = 1000
                MilesSinCosto = 0
                HayKM = False
                CantidadKM = 0

                'Solo se afectarán los Estatus RB
                If Punto("Status") <> "RB" Then Continue For
                'Cuando es un Despacho se brinca. Solo debe recalcular las Recolecciones
                If Punto("TipoTV") = 2 Then Continue For

0:              'Revisar si el Id_Punto ya existe en Cat_Movimientos. Solo se buscan puntos
                'RB porque En el proceso anterior (Grabar Servicio) todos los puntos RU 
                'se cambiaron a RB. Los que se quedaron RU es porque no se recibieron completos
                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Movimientos_GetByPunto")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.VarChar, "T")
                Dt_Movimientos = Cn_Datos.EjecutaConsultaT(Cmd)

                'Si no se pudo consultar se sale
                If Dt_Movimientos Is Nothing Then Continue For
                'Cuando ya existe un Movimiento se recalcula
                If Dt_Movimientos.Rows.Count > 0 Then
                    Id_Movimiento = Dt_Movimientos.Rows(0)("Id_Movimiento")
                    TipoTV = Dt_Movimientos.Rows(0)("TipoTV")
                    Movimiento_Verificado = Dt_Movimientos.Rows(0)("Mov_VerificadoRec")
                Else
                    Id_Movimiento = 0
                    Movimiento_Verificado = 0
                End If
                Dt_Movimientos = Nothing

                'Si el punto ya se verificó en una pasada Anterior, ya no se hace nada, se brinca al siguiente
                If Movimiento_Verificado = 1 Then Continue For

                Id_CS = Punto("Id_CS")
                Importe = Punto("Importe")
                'Cantidad_Envases = Punto("Cantidad_Envases")
                Cantidad_Remisiones = Punto("Cantidad_Remisiones")
                Id_Cliente = Punto("Cliente_Origen")

                'Con el Id_CS traer el Id_Precio, Id_CR, Id_EE, Id_KM
                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesServicios_Read")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                Dt_Datos = Cn_Datos.EjecutaConsultaT(Cmd)

                If Dt_Datos Is Nothing Then
                    GoTo SiguientePunto
                End If
                If Dt_Datos.Rows.Count = 0 Then
                    GoTo SiguientePunto
                End If
                Id_Precio = Dt_Datos.Rows(0)("Id_Precio")
                Id_CR = Dt_Datos.Rows(0)("Id_CR")
                Id_EE = Dt_Datos.Rows(0)("Id_EE")
                Id_KM = Dt_Datos.Rows(0)("Id_KM")
                Dt_Datos = Nothing

                'Consutlar los datos de CR para hacer los cálculos
                If Id_CR > 0 Then
                    Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_CuotaRiesgo_Read")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                    Dt_Datos = Cn_Datos.EjecutaConsultaT(Cmd)

                    If Dt_Datos Is Nothing Then
                        GoTo SiguientePunto
                    End If
                    If Dt_Datos.Rows.Count > 0 Then
                        HayCR = True
                        Cobra_Doctos = Microsoft.VisualBasic.Left(Dt_Datos.Rows(0)("CobraDocumentos"), 1)
                        Redondeado = Microsoft.VisualBasic.Left(Dt_Datos.Rows(0)("Redondeado"), 1)
                        CantidadXunidad = Dt_Datos.Rows(0)("CantidadXunidad")
                        MilesSinCosto = Dt_Datos.Rows(0)("MilesScosto")
                    End If
                End If
                Dt_Datos = Nothing
                'Consultar los datos de KM para Hacer los cálculos
                HayKM = False
                CantidadKM = 0
                If Id_KM > 0 Then
                    Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Kilometros_Read")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                    Dt_Datos = Cn_Datos.EjecutaConsultaT(Cmd)

                    If Dt_Datos Is Nothing Then
                        GoTo SiguientePunto
                    End If
                    If Dt_Datos.Rows.Count > 0 Then
                        'Si hay CR
                        HayKM = True
                        CantidadKM = Dt_Datos.Rows(0)("CantidadKM")
                    End If
                End If
                Dt_Datos = Nothing

                'Leer las Remisiones del punto para Insertar en Cat_MovimientosD
                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Tv_puntosRemisiones_GetD")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "T")
                Dt_Remisiones = Cn_Datos.EjecutaConsultaT(Cmd)

                For Each Remision As DataRow In Dt_Remisiones.Rows
                    Cantidad_Envases += (Remision("Envases") + Remision("EnvasesSN"))

                    '1.- Recalcular la remision
                    Cmd = Cn_Datos.Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_Remisiones_Recalcular")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                    Cn_Datos.EjecutarNonQueryT(Cmd)

                    '2.- Consultar Importe Efectivo e Importe Documentos
                    Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_RemisionesD_GetTotales")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                    Dt_RemisionesD = Cn_Datos.EjecutaConsultaT(Cmd)

                    If Dt_RemisionesD IsNot Nothing Then
                        If Dt_RemisionesD.Rows.Count > 0 Then
                            Importe_Efectivo += Dt_RemisionesD.Rows(0)("Efectivo")
                            Importe_Documentos += Dt_RemisionesD.Rows(0)("Documentos")
                        End If
                    End If
                    Dt_RemisionesD = Nothing
                Next

                'Hacer los calculos de los Miles
                If Cobra_Doctos = "S" Then Importe = Importe_Efectivo + Importe_Documentos Else Importe = Importe_Efectivo
                If Redondeado = "S" Then
                    If Importe Mod CantidadXunidad > 0 Then
                        If Importe Mod CantidadXunidad >= 999.5 Then
                            Miles = ((Importe \ CantidadXunidad)) - MilesSinCosto
                            'Le quité el "+1" porque cuando el resultado del mod es muy cercano a 1000
                            'se redondea automaticamente y el calculo de los miles sale mal
                            'sale 1 mil de mas
                        Else
                            Miles = ((Importe \ CantidadXunidad) + 1) - MilesSinCosto
                        End If
                    Else
                        Miles = (Importe / CantidadXunidad) - MilesSinCosto
                    End If
                Else
                    Miles = (Importe / CantidadXunidad) - MilesSinCosto
                End If
                If Miles < 0 Then Miles = 0

                'Se manda como Cero porque este campo ya no se usa
                Envases_Exceso = 0

                If Id_Movimiento = 0 Then
                    'Insertar en Cat_Movimientos
                    Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Movimientos_Create")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.VarChar, "R")
                    Cn_Datos.Crea_Parametro(Cmd, "@Hora", SqlDbType.VarChar, Left(Now.TimeOfDay.ToString, 5))
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Id_Ruta)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EE", SqlDbType.Int, Id_EE)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
                    Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
                    Cn_Datos.Crea_Parametro(Cmd, "@Miles", SqlDbType.Money, Miles)
                    Cn_Datos.Crea_Parametro(Cmd, "@Envases_Exceso", SqlDbType.Int, Envases_Exceso)
                    Cn_Datos.Crea_Parametro(Cmd, "@Kilometros", SqlDbType.Int, CantidadKM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Captura", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, 1)
                    Id_Movimiento = Cn_Datos.EjecutarScalarT(Cmd)

                    'Insertar en Cat_MovimientosD
                    For Each Remision As DataRow In Dt_Remisiones.Rows
                        Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_MovimientosD_Create")
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                        Cn_Datos.EjecutarNonQueryT(Cmd)
                    Next
                    Dt_Remisiones = Nothing
                Else
                    'Actualizar en Cat_Movimientos
                    Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Movimientos_Update")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EE", SqlDbType.Int, Id_EE)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Id_Ruta)
                    Cn_Datos.Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)
                    Cn_Datos.Crea_Parametro(Cmd, "@Hora", SqlDbType.VarChar, Left(Now.TimeOfDay.ToString, 5))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
                    Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
                    Cn_Datos.Crea_Parametro(Cmd, "@Miles", SqlDbType.Money, Miles)
                    Cn_Datos.Crea_Parametro(Cmd, "@Envases_Exceso", SqlDbType.Int, Envases_Exceso)
                    Cn_Datos.Crea_Parametro(Cmd, "@Kilometros", SqlDbType.Int, CantidadKM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Captura", SqlDbType.VarChar, EstacioN)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                    'Borrar las Remisiones de Cat_MovimientosD

                    For Each Remision As DataRow In Dt_Remisiones.Rows
                        'Este procedimiento Primero checa, si ya existe ya no lo inserta
                        Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_MovimientosD_Create2")
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                        Cn_Datos.EjecutarNonQueryT(Cmd)
                    Next
                    Dt_Remisiones = Nothing
                End If

                'Marcar el Punto como Mov_VerificadoRec=1 para que ya no se considere en las siguientes pasadas por esta función
                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "TV_Puntos_UpdateRec")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                Cn_Datos.Crea_Parametro(Cmd, "@Mov_VerificadoRec", SqlDbType.Int, 1)
                Cn_Datos.EjecutarNonQueryT(Cmd)

SiguientePunto:
            Next 'Puntos
        Catch ex As Exception

            Tr.Rollback()
            cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        Tr.Commit()
        cnn.Close()
        Return True
    End Function

    Public Shared Function fn_RecRutasPropias_LlenarListaPuntosyRemisiones(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean
        Try
            '11/08/2014
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Tv_Puntos_GetRemisiones", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)

            With lsv
                .Actualizar(Cmd, "Id_Remision")
                .Columns(0).TextAlign = HorizontalAlignment.Right
                .Columns(6).TextAlign = HorizontalAlignment.Right
                .Columns(7).TextAlign = HorizontalAlignment.Right
                .Columns(10).Width = 75
                .Columns(11).Width = 65
            End With

            For I As Integer = 12 To lsv.Columns.Count - 1
                lsv.Columns(I).Width = 0
            Next

            For Each elemento As ListViewItem In lsv.Items
                If elemento.SubItems(5).Text.Trim = "VALIDADO" And Microsoft.VisualBasic.Left(elemento.SubItems(8).Text.Trim.ToUpper, 1) = "B" Then
                    elemento.BackColor = Color.LightGreen
                End If
            Next
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_IniciarServicios_ObtenerMovimiento(ByVal Id_Remision As Integer) As DataRow
        Dim cmd As SqlCommand = Crea_Comando("ObtenerMovimiento_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_remision", SqlDbType.Int, Id_Remision)
        Try
            Dim dt As DataTable = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
    'Se quito esta parte por que solo mandava el status validado pero no el ususio que relizo la validacion.
    'Public Shared Function fn_FacturacionActualizarRemision(ByVal Id_Remision As String) As String
    '    Dim Cmd As SqlCommand = Crea_Comando("ValidarFacturacion", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Try
    '        Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.VarChar, Id_Remision)


    '        EjecutarNonQuery(Cmd)


    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try

    'End Function

    Public Shared Function fn_RecRutasPropias_LlenarListaRutasPendientes(ByVal lsv As cp_Listview, ByVal Fecha As Date) As Integer
        Try
            '27/08/2014
            Dim RutasRecibidas As Integer = 0
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("TV_Programacion_GetPuntosPendientes", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            lsv.Actualizar(Cmd, "Id_Programacion")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            For Each elemento As ListViewItem In lsv.Items
                If CInt(elemento.SubItems(3).Text) = 0 Then
                    elemento.BackColor = Color.LightGreen
                    RutasRecibidas += 1
                End If
            Next
            Return RutasRecibidas
        Catch ex As Exception
            TrataEx(ex)
            Return -1
        End Try

    End Function


#End Region

#Region "Administracion de Caset"

    Public Shared Function fn_Kardex_Caset_Read(ByVal Codigo_Barras As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Codigo_Barra", SqlDbType.VarChar, Codigo_Barras)
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


    Public Shared Function fn_Kardex_Caset_Get(ByVal Lista As cp_Listview, ByVal Fecha As Date, ByVal Id_Programacion As Integer, ByVal Id_Movimiento As Integer) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
            Crea_Parametro(cmd, "@Fecha", SqlDbType.Date, Fecha)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@TipoP", SqlDbType.Int, 1)
            Lista.Actualizar(cmd, "Id_Caset")
        Catch ex As Exception
            TrataEx(ex)
            cnn.Dispose()
            cmd.Dispose()
            Return False
        Finally
            cnn.Dispose()
            cmd.Dispose()
        End Try
        Return True
    End Function
    Public Shared Function fn_Kardex_Caset_GetEntradas(ByVal Fecha As Date, ByVal Id_Programacion As Integer, ByVal Id_Movimiento As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim dt_CasetEntradas As DataTable = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_GetEntradas", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
            Crea_Parametro(cmd, "@Fecha", SqlDbType.Date, Fecha)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@TipoP", SqlDbType.Int, 1)

            dt_CasetEntradas = EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex)
            cnn.Dispose()
            cmd.Dispose()
            Return Nothing
        End Try
        Return dt_CasetEntradas
    End Function

    Public Shared Function fn_Kardex_Caset_Insert(ByVal IdCodigo_Caset As String, ByVal IdCodigo_Barra As String, ByVal Id_Cliente As Integer, ByVal Serie As String, ByVal Descripcion As String, ByVal Capacidad As Integer) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_Create", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Codigo_Caset", SqlDbType.VarChar, IdCodigo_Caset)
            Crea_Parametro(cmd, "@Id_Codigo_Barra", SqlDbType.VarChar, IdCodigo_Barra)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Serie", SqlDbType.VarChar, Serie)
            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Crea_Parametro(cmd, "@Capacidad", SqlDbType.Int, Capacidad)

            If EjecutarNonQuery(cmd) > 0 Then
                Return True
            End If

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
            Cmd = Crea_Comando("Kardex_Get", CommandType.StoredProcedure, Cnn)
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

    Public Shared Function fn_Kardex_Catalogo_Baja(ByVal Id As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Kardex_UpdateStatus", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Caset", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Kardex_Movimientos_Insert(ByVal Lista As cp_Listview, ByVal Id_Kardex_Movimiento As Integer, ByVal UsuarioIdRecibe As Integer) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim tr As SqlTransaction = Nothing
        Dim DescripcionCatMovimiento As String = ""

        If Id_Kardex_Movimiento = 1 Then
            DescripcionCatMovimiento = "ENTRADA CUSTODIO"
        ElseIf Id_Kardex_Movimiento = 4 Then
            DescripcionCatMovimiento = "SALIDA CUSTODIO"
        End If

        Try
            cnn = Crea_ConexionSTD()
            tr = crear_Trans(cnn)

            cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_CatMovimiento_GetId")
            Cn_Datos.Crea_Parametro(cmd, "@Descricion", SqlDbType.VarChar, DescripcionCatMovimiento)
            Dim Id_KardexCatMovimiento As Integer = EjecutarScalarT(cmd)


            For Each elemento As ListViewItem In Lista.CheckedItems
                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Movimientos_Create")
                Cn_Datos.Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, elemento.Tag)
                Cn_Datos.Crea_Parametro(cmd, "@Id_Kardex_Cat_Movimiento", SqlDbType.Int, Id_Kardex_Movimiento)
                Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado_Entrega", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado_Recibe", SqlDbType.Int, UsuarioIdRecibe)
                Cn_Datos.Crea_Parametro(cmd, "@EstacionN", SqlDbType.VarChar, EstacioN)

                EjecutarNonQueryT(cmd)

                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Caset_UpdateSalidaEntrada")
                Cn_Datos.Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, elemento.Tag)
                Cn_Datos.Crea_Parametro(cmd, "@IdKardex_Cat_Movimiento", SqlDbType.Int, Id_Kardex_Movimiento)

                EjecutarNonQueryT(cmd)



                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Movimientos_Caset_Insert")
                Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, elemento.Tag)
                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, 0)
                Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, UsuarioIdRecibe)
                Crea_Parametro(cmd, "@Id_Codigo_barra", SqlDbType.VarChar, elemento.Text)
                Crea_Parametro(cmd, "@Id_Kardex_Cat_Movimiento", SqlDbType.Int, Id_KardexCatMovimiento)

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

    Public Shared Function fn_Kardex_MovimientosCaset_Insert(ByVal lsv As ListView, ByVal Id_Programacion As Integer, ByVal EntregaCliente As Boolean, ByVal RecibeDelCliente As Boolean, ByVal tipoMovimiento As Integer) As Integer
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim tr As SqlTransaction = Nothing

        Try
            For Each item As ListViewItem In lsv.Items
                cnn = Crea_ConexionSTD()
                tr = crear_Trans(cnn)

                If Not RecibeDelCliente Then
                    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_CasetCliente_Read")
                    Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
                    Crea_Parametro(cmd, "@Id_Codigo_Barra", SqlDbType.VarChar, item.SubItems(1).Text)
                    Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, item.SubItems(2).Text)

                    If EjecutaConsultaT(cmd).Rows.Count = 0 Then
                        tr.Rollback()
                        Return 2
                    End If
                End If

                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Caset_GetId")
                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, item.SubItems(2).Text)
                Dim Id_Caset As Integer = EjecutarScalarT(cmd)

                If Id_Caset = 0 Then
                    tr.Rollback()
                    cnn.Dispose()
                    Return -1
                End If

                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Movimientos_Caset_Insert")

                Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, Id_Caset)
                Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, item.SubItems(2).Text)
                Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Id_Codigo_barra", SqlDbType.VarChar, item.SubItems(1).Text)
                Crea_Parametro(cmd, "@Id_Kardex_Cat_Movimiento", SqlDbType.Int, tipoMovimiento)

                If EntregaCliente Then

                    EjecutarNonQueryT(cmd)

                    tr.Commit()

                ElseIf RecibeDelCliente Then
                    Dim Id_MovimientoCaset As Integer = EjecutarScalarT(cmd)

                    If Id_MovimientoCaset = 0 Then
                        tr.Rollback()
                        cnn.Dispose()
                        cmd.Dispose()
                        Return -1
                    End If

                    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Remisiones_GetNumero")
                    Crea_Parametro(cmd, "@Id_ClienteOrigen", SqlDbType.Int, item.SubItems(2).Text)
                    Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)


                    Dim dt As DataTable = EjecutaConsultaT(cmd)

                    If dt.Rows.Count = 0 Then
                        tr.Rollback()
                        cnn.Dispose()
                        cmd.Dispose()
                        Return -1
                    End If

                    '' habrá ocasiones en la que el cliente tendrá mas de una remisión cuando haya uno preceso de resguardo
                    For Each dr As DataRow In dt.Rows
                        cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_MovimientosCaset_Remisiones_Insert")
                        Crea_Parametro(cmd, "@Id_Movimiento_Caset", SqlDbType.Int, Id_MovimientoCaset)
                        Crea_Parametro(cmd, "@Id_Remision", SqlDbType.Int, CInt(dr("Id_Remision")))
                        EjecutarNonQueryT(cmd)
                    Next
                End If
            Next
        Catch ex As Exception
            tr.Rollback()
            cnn.Dispose()
            cmd.Dispose()
            TrataEx(ex)
            Return -1
        End Try
        Return 1
    End Function

    Public Shared Function fn_Kardex_CasetAutoriza_get() As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_CasetAutoriza_Get", CommandType.StoredProcedure, cnn)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            cnn.Dispose()
            cmd.Dispose()
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Kardex_CasetAutoriza_Actualizar(ByVal Kardex_CaseAutoriza As Integer, ByVal Id_Empleado As Integer)
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_CasetAutoriza_Update", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_CasetAutoriza", SqlDbType.Int, Kardex_CaseAutoriza)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            EjecutarNonQuery(cmd)
        Catch ex As Exception
            cnn.Dispose()
            cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_kardex_CasetAutoriza_Baja(ByVal Id_CasetAutoriza As Integer)
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_CasetAutoriza_UpdateBaja", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_CasetAutoriza", SqlDbType.Int, Id_CasetAutoriza)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "B")
            EjecutarNonQuery(cmd)
        Catch ex As Exception
            cnn.Dispose()
            cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_Movimientos_GetSalidas(ByVal Id_Programacion As Integer, ByVal Id_CatMovimiento As Integer) As Integer
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Movimientos_GetSalidas", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
            Crea_Parametro(cmd, "@Id_KadexCatMovimiento", SqlDbType.Int, Id_CatMovimiento)
            Return EjecutarScalar(cmd)
        Catch ex As Exception
            cnn.Dispose()
            cmd.Dispose()
            TrataEx(ex)
            Return -1
        End Try
    End Function

    Public Shared Function fn_Kardex_MovimientosCaset_GetEntradas(ByVal Id_Programacion As Integer, ByVal Id_CatMovimiento As Integer)
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_MovimientosCaset_GetEntradas", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
            Crea_Parametro(cmd, "@Id_KadexCatMovimiento", SqlDbType.Int, Id_CatMovimiento)
            Return EjecutarScalar(cmd)
        Catch ex As Exception
            cnn.Dispose()
            cmd.Dispose()
            TrataEx(ex)
            Return -1
        End Try
    End Function





#End Region

#Region "Alta de Movimientos para Prefactura en rutas no propias"
    Public Shared Function fn_RecRutasExternas_GuardarXRemision(ByVal ID_Boveda As Integer, ByVal ID_Programacion As Integer, ByVal Lsv_Remisiones As cp_Listview, ByVal Fecha As Date, ByVal Id_Ruta As Integer) As Integer
        'En esta parte guarda los movimientos
        If Not fn_RecRutasExternas_GuardaMovimientos(ID_Programacion, Fecha, Id_Ruta) Then
            Return -2
        End If

    End Function

    Public Shared Function fn_RecRutasExternas_GuardaMovimientos(ByVal ID_Programacion As Integer, ByVal Fecha As Date, ByVal Id_Ruta As Integer) As Boolean

        'Revisar que todos los puntos tengan su movimiento
        'y cuando no lo tengan se debe insertar uno
        Dim cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim Dt_Remisiones As DataTable
        Dim Dt_Movimientos As DataTable
        Dim Dt_Datos As DataTable
        Dim Dt_RemisionesD As DataTable
        '
        'Datos para el Movimiento
        Dim Id_Movimiento As Integer = 0
        Dim Id_Cliente As Integer
        Dim Id_CS As Integer
        Dim Id_Precio As Integer
        Dim Id_CR As Integer
        Dim Id_EE As Integer
        Dim Id_KM As Integer
        Dim Cantidad_Remisiones As Integer
        Dim Cantidad_Envases As Integer
        Dim Envases_Exceso As Integer
        Dim Importe As Decimal
        Dim Importe_Efectivo As Decimal
        Dim Importe_Documentos As Decimal
        Dim Miles As Decimal
        Dim Dt_Puntos As DataTable
        Dim TipoTV As Byte

        Dim HayCR As Boolean
        Dim Cobra_Doctos As String
        Dim Redondeado As String
        Dim CantidadXunidad As Integer
        Dim MilesSinCosto As Integer

        Dim HayKM As Boolean
        Dim CantidadKM As Integer
        Dim Movimiento_Verificado As Integer
        Tr = crear_Trans(cnn)
        Try
            'Consultar todos los Puntos de la Ruta 
            Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Tv_Puntos_ReadTodos")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_Programacion)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "RB")

            Dt_Puntos = Cn_Datos.EjecutaConsultaT(Cmd)

            'Recorrer el dt_puntos 
            For Each Punto As DataRow In Dt_Puntos.Rows
                Cantidad_Envases = 0
                Cantidad_Remisiones = 0
                Importe_Efectivo = 0
                Importe_Documentos = 0
                Importe = 0
                Miles = 0
                Id_CS = 0
                Id_CR = 0
                Id_KM = 0
                Id_EE = 0
                Id_Precio = 0
                Id_Movimiento = 0
                Movimiento_Verificado = 0
                HayCR = False
                Cobra_Doctos = "N"
                Redondeado = "S"
                CantidadXunidad = 1000
                MilesSinCosto = 0
                HayKM = False
                CantidadKM = 0

                'Solo se afectarán los Estatus RB
                If Punto("Status") <> "RB" Then Continue For
                'Cuando es un Despacho se brinca. Solo debe recalcular las Recolecciones
                If Punto("TipoTV") = 2 Then Continue For

0:              'Revisar si el Id_Punto ya existe en Cat_Movimientos. Solo se buscan puntos
                'RB porque En el proceso anterior (Grabar Servicio) todos los puntos RU 
                'se cambiaron a RB. Los que se quedaron RU es porque no se recibieron completos
                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Movimientos_GetByPunto")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.VarChar, "T")
                Dt_Movimientos = Cn_Datos.EjecutaConsultaT(Cmd)

                'Si no se pudo consultar se sale
                If Dt_Movimientos Is Nothing Then Continue For
                'Cuando ya existe un Movimiento se recalcula
                If Dt_Movimientos.Rows.Count > 0 Then
                    Id_Movimiento = Dt_Movimientos.Rows(0)("Id_Movimiento")
                    TipoTV = Dt_Movimientos.Rows(0)("TipoTV")
                    Movimiento_Verificado = Dt_Movimientos.Rows(0)("Mov_VerificadoRec")
                Else
                    Id_Movimiento = 0
                    Movimiento_Verificado = 0
                End If
                Dt_Movimientos = Nothing

                'Si el punto ya se verificó en una pasada Anterior, ya no se hace nada, se brinca al siguiente
                If Movimiento_Verificado = 1 Then Continue For

                Id_CS = Punto("Id_CS")
                Importe = Punto("Importe")
                'Cantidad_Envases = Punto("Cantidad_Envases")
                Cantidad_Remisiones = Punto("Cantidad_Remisiones")
                Id_Cliente = Punto("Cliente_Origen")

                'Con el Id_CS traer el Id_Precio, Id_CR, Id_EE, Id_KM
                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_ClientesServicios_Read")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                Dt_Datos = Cn_Datos.EjecutaConsultaT(Cmd)

                If Dt_Datos Is Nothing Then
                    GoTo SiguientePunto
                End If
                If Dt_Datos.Rows.Count = 0 Then
                    GoTo SiguientePunto
                End If
                Id_Precio = Dt_Datos.Rows(0)("Id_Precio")
                Id_CR = Dt_Datos.Rows(0)("Id_CR")
                Id_EE = Dt_Datos.Rows(0)("Id_EE")
                Id_KM = Dt_Datos.Rows(0)("Id_KM")
                Dt_Datos = Nothing

                'Consutlar los datos de CR para hacer los cálculos
                If Id_CR > 0 Then
                    Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_CuotaRiesgo_Read")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                    Dt_Datos = Cn_Datos.EjecutaConsultaT(Cmd)

                    If Dt_Datos Is Nothing Then
                        GoTo SiguientePunto
                    End If
                    If Dt_Datos.Rows.Count > 0 Then
                        HayCR = True
                        Cobra_Doctos = Microsoft.VisualBasic.Left(Dt_Datos.Rows(0)("CobraDocumentos"), 1)
                        Redondeado = Microsoft.VisualBasic.Left(Dt_Datos.Rows(0)("Redondeado"), 1)
                        CantidadXunidad = Dt_Datos.Rows(0)("CantidadXunidad")
                        MilesSinCosto = Dt_Datos.Rows(0)("MilesScosto")
                    End If
                End If
                Dt_Datos = Nothing
                'Consultar los datos de KM para Hacer los cálculos
                HayKM = False
                CantidadKM = 0
                If Id_KM > 0 Then
                    Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Kilometros_Read")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                    Dt_Datos = Cn_Datos.EjecutaConsultaT(Cmd)

                    If Dt_Datos Is Nothing Then
                        GoTo SiguientePunto
                    End If
                    If Dt_Datos.Rows.Count > 0 Then
                        'Si hay CR
                        HayKM = True
                        CantidadKM = Dt_Datos.Rows(0)("CantidadKM")
                    End If
                End If
                Dt_Datos = Nothing

                'Leer las Remisiones del punto para Insertar en Cat_MovimientosD
                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Tv_puntosRemisiones_GetD")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                Cn_Datos.Crea_Parametro(Cmd, "@Dpto_Registro", SqlDbType.VarChar, "T")
                Dt_Remisiones = Cn_Datos.EjecutaConsultaT(Cmd)

                For Each Remision As DataRow In Dt_Remisiones.Rows
                    Cantidad_Envases += (Remision("Envases") + Remision("EnvasesSN"))

                    '1.- Recalcular la remision
                    Cmd = Cn_Datos.Crea_ComandoT(Tr.Connection, Tr, CommandType.StoredProcedure, "Cat_Remisiones_Recalcular")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                    Cn_Datos.EjecutarNonQueryT(Cmd)

                    '2.- Consultar Importe Efectivo e Importe Documentos
                    Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_RemisionesD_GetTotales")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                    Dt_RemisionesD = Cn_Datos.EjecutaConsultaT(Cmd)

                    If Dt_RemisionesD IsNot Nothing Then
                        If Dt_RemisionesD.Rows.Count > 0 Then
                            Importe_Efectivo += Dt_RemisionesD.Rows(0)("Efectivo")
                            Importe_Documentos += Dt_RemisionesD.Rows(0)("Documentos")
                        End If
                    End If
                    Dt_RemisionesD = Nothing
                Next

                'Hacer los calculos de los Miles
                If Cobra_Doctos = "S" Then Importe = Importe_Efectivo + Importe_Documentos Else Importe = Importe_Efectivo

                If Redondeado = "S" Then
                    If Importe Mod CantidadXunidad > 0 Then
                        If Importe Mod CantidadXunidad >= 999.5 Then
                            Miles = ((Importe \ CantidadXunidad)) - MilesSinCosto
                            'Le quité el "+1" porque cuando el resultado del mod es muy cercano a 1000
                            'se redondea automaticamente y el calculo de los miles sale mal
                            'sale 1 mil de mas
                        Else
                            Miles = ((Importe \ CantidadXunidad) + 1) - MilesSinCosto
                        End If
                    Else
                        Miles = (Importe / CantidadXunidad) - MilesSinCosto
                    End If
                Else
                    Miles = (Importe / CantidadXunidad) - MilesSinCosto
                End If
                If Miles < 0 Then Miles = 0

                'Se manda como Cero porque este campo ya no se usa
                Envases_Exceso = 0

                If Id_Movimiento = 0 Then
                    'Insertar en Cat_Movimientos
                    Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Movimientos_Create")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mov", SqlDbType.VarChar, "R")
                    Cn_Datos.Crea_Parametro(Cmd, "@Hora", SqlDbType.VarChar, Left(Now.TimeOfDay.ToString, 5))
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Id_Ruta)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EE", SqlDbType.Int, Id_EE)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
                    Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
                    Cn_Datos.Crea_Parametro(Cmd, "@Miles", SqlDbType.Money, Miles)
                    Cn_Datos.Crea_Parametro(Cmd, "@Envases_Exceso", SqlDbType.Int, Envases_Exceso)
                    Cn_Datos.Crea_Parametro(Cmd, "@Kilometros", SqlDbType.Int, CantidadKM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Captura", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.Crea_Parametro(Cmd, "@Modo_Captura", SqlDbType.Int, 1)
                    Id_Movimiento = Cn_Datos.EjecutarScalarT(Cmd)

                    'Insertar en Cat_MovimientosD
                    For Each Remision As DataRow In Dt_Remisiones.Rows
                        Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_MovimientosD_Create")
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                        Cn_Datos.EjecutarNonQueryT(Cmd)
                    Next
                    Dt_Remisiones = Nothing
                Else
                    'Actualizar en Cat_Movimientos
                    Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_Movimientos_Update")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Precio", SqlDbType.Int, Id_Precio)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CR", SqlDbType.Int, Id_CR)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EE", SqlDbType.Int, Id_EE)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_KM", SqlDbType.Int, Id_KM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Ruta", SqlDbType.Int, Id_Ruta)
                    Cn_Datos.Crea_Parametro(Cmd, "@Fecha", SqlDbType.Date, Fecha)
                    Cn_Datos.Crea_Parametro(Cmd, "@Hora", SqlDbType.VarChar, Left(Now.TimeOfDay.ToString, 5))
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Remisiones", SqlDbType.Int, Cantidad_Remisiones)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Envases", SqlDbType.Int, Cantidad_Envases)
                    Cn_Datos.Crea_Parametro(Cmd, "@Importe", SqlDbType.Money, Importe)
                    Cn_Datos.Crea_Parametro(Cmd, "@Miles", SqlDbType.Money, Miles)
                    Cn_Datos.Crea_Parametro(Cmd, "@Envases_Exceso", SqlDbType.Int, Envases_Exceso)
                    Cn_Datos.Crea_Parametro(Cmd, "@Kilometros", SqlDbType.Int, CantidadKM)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_CS", SqlDbType.Int, Id_CS)
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                    'Borrar las Remisiones de Cat_MovimientosD

                    For Each Remision As DataRow In Dt_Remisiones.Rows
                        'Este procedimiento Primero checa, si ya existe ya no lo inserta
                        Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_MovimientosD_Create2")
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Movimiento", SqlDbType.Int, Id_Movimiento)
                        Cn_Datos.Crea_Parametro(Cmd, "@Id_Remision", SqlDbType.Int, Remision("Id_Remision"))
                        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                        Cn_Datos.EjecutarNonQueryT(Cmd)
                    Next
                    Dt_Remisiones = Nothing
                End If

                'Marcar el Punto como Mov_VerificadoRec=1 para que ya no se considere en las siguientes pasadas por esta función
                Cmd = Cn_Datos.Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "TV_Puntos_UpdateRec")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Punto("Id_Punto"))
                Cn_Datos.Crea_Parametro(Cmd, "@Mov_VerificadoRec", SqlDbType.Int, 1)
                Cn_Datos.EjecutarNonQueryT(Cmd)

SiguientePunto:
            Next 'Puntos
        Catch ex As Exception

            Tr.Rollback()
            cnn.Close()
            TrataEx(ex)
            Return False
        End Try

        Tr.Commit()
        cnn.Close()
        Return True
    End Function

#End Region

#Region "CONTROL CASET"
    Public Shared Function fn_Kardex_Caset_GetClienteAsigando(ByVal Id_Programacion As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try

            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_Caset_GetAsignados", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "AC")
            Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Kardex_CasetAsignaRuta(ByVal Id_Programacion As Integer, ByVal dgv As DataGridView) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim tr As SqlTransaction = Nothing

        Try
            cnn = Crea_ConexionSTD()
            tr = crear_Trans(cnn)

            For Each gvr As DataGridViewRow In dgv.Rows
                If Convert.ToBoolean(gvr.Cells(0).Value) Then
                    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_CasetAsignaRuta_Create")
                    Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, CInt(gvr.Cells(1).Value))
                    Crea_Parametro(cmd, "@Id_ClienteAsignado", SqlDbType.Int, CInt(gvr.Cells(5).Value))
                    Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "AT")
                    Crea_Parametro(cmd, "@Usuario_Asigna", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_Asigna", SqlDbType.VarChar, EstacioN)
                    Crea_Parametro(cmd, "@Tipo", SqlDbType.SmallInt, 1)

                    If EjecutarNonQueryT(cmd) = 0 Then
                        tr.Rollback()
                        Return False
                    End If

                    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_CasetES_Create")
                    Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, CInt(gvr.Cells(1).Value))
                    Crea_Parametro(cmd, "@Id_ClienteAsignado", SqlDbType.Int, CInt(gvr.Cells(5).Value))
                    Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "S")
                    Crea_Parametro(cmd, "@Usuario_ES", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_ES", SqlDbType.VarChar, UsuarioN)
                    If EjecutarNonQueryT(cmd) = 0 Then
                        tr.Rollback()
                        Return False
                    End If

                    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Caset_UpdateAsignaRuta")
                    Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, CInt(gvr.Cells(1).Value))
                    Crea_Parametro(cmd, "@EnBoveda", SqlDbType.VarChar, "F")
                    If EjecutarNonQueryT(cmd) = 0 Then
                        tr.Rollback()
                        Return False
                    End If

                End If
            Next
            tr.Commit()
        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex, True)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_CasetAsinadoRuta_Get(ByVal lsv As cp_Listview, ByVal Id_Programacion As Integer, ByVal Id_Cliente As Integer, ByVal Tipo As Integer) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_CasetAsignaRuta_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "ER")
            Crea_Parametro(cmd, "@Tipo", SqlDbType.SmallInt, Tipo)
            lsv.Actualizar(cmd, "Id_AsignacionR")
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_Kardex_CasetAsinadoRuta_GetRecepcion(ByVal Id_Programacion As Integer, ByVal Id_Cliente As Integer, ByVal Tipo As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("Kardex_CasetAsignaRuta_GetRecepcion", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "ER")
            Crea_Parametro(cmd, "@Tipo", SqlDbType.SmallInt, Tipo)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Kardex_Caset_GetClienteEnPunto(ByVal Id_Programacion As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Try

            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("kardex_CasetClienteEnPunto", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Kardex_CasetGuardar(ByVal dgv As DataGridView, ByVal Id_Programacion As Integer) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim tr As SqlTransaction = Nothing

        Try
            cnn = Crea_ConexionSTD()
            tr = crear_Trans(cnn)

            For Each dr As DataGridViewRow In dgv.Rows
                If Convert.ToBoolean(dr.Cells(0).Value) Then
                    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_CasetES_Create")
                    Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, dr.Cells("Id_Caset").Value)
                    Crea_Parametro(cmd, "@Id_ClienteAsignado", SqlDbType.Int, dr.Cells("Id_ClienteAsignado").Value)
                    Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "E")
                    Crea_Parametro(cmd, "@Usuario_ES", SqlDbType.Int, UsuarioId)
                    Crea_Parametro(cmd, "@Estacion_ES", SqlDbType.VarChar, EstacioN)
                    If EjecutarNonQueryT(cmd) = 0 Then
                        tr.Rollback()
                        Return False
                    End If

                    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_CasetAsignaRuta_UpdateAsignarSissa")
                    Crea_Parametro(cmd, "@Id_AsignacionR", SqlDbType.Int, dr.Cells("Id_AsignacionR").Value)
                    Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "ES")

                    If EjecutarNonQueryT(cmd) = 0 Then
                        tr.Rollback()
                        Return False
                    End If

                    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Caset_UpdateAsinadoSissa")
                    Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, dr.Cells("Id_Caset").Value)
                    Crea_Parametro(cmd, "@EnBoveda", SqlDbType.VarChar, "D")

                    If EjecutarNonQueryT(cmd) = 0 Then
                        tr.Rollback()
                        Return False
                    End If
                End If                
            Next
            tr.Commit()
        Catch ex As Exception
            tr.Commit()
            cnn.Dispose()
            cmd.Dispose()
            TrataEx(ex, True)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function fn_KardexCaset_ESRecepcion(ByVal Id_Programacion As Integer, ByVal Id_Cliente As Integer, ByVal Status As String) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Try
            cnn = Crea_ConexionSTD()
            cmd = Crea_Comando("KardexCaset_EntradaSalidaRecepcion", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, Id_Programacion)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
            'Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

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

    Public Shared Function fn_Kardex_Caset_AsignaCliente(ByVal lsv As cp_Listview, ByVal Fecha As Date)
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim tr As SqlTransaction = Nothing

        Try
            cnn = Crea_ConexionSTD()
            tr = crear_Trans(cnn)

            For Each item As ListViewItem In lsv.CheckedItems

                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_CasetAsignaCliente_Insert")
                Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, CInt(item.Tag))
                Crea_Parametro(cmd, "@Id_Cliente_Asignado", SqlDbType.Int, item.Text.Split("'")(1))
                Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
                Crea_Parametro(cmd, "@Usuario_Asigna", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Fecha_Asigna", SqlDbType.Date, Fecha)
                Crea_Parametro(cmd, "@Estacion_Asigna", SqlDbType.VarChar, EstacioN)
                EjecutarNonQueryT(cmd)

                cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Caset_UpdateAsignado")
                Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, CInt(item.Tag))
                Crea_Parametro(cmd, "@Id_Cliente_Asignado", SqlDbType.Int, item.Text.Split("'")(1))
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

    Public Shared Function fn_Kardex_Caset_AsignaSeguridadInterna(ByVal Id_Caset As Integer, ByVal Id_Cliente As Integer, ByVal Fecha As Date)
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim tr As SqlTransaction = Nothing

        Try
            cnn = Crea_ConexionSTD()
            tr = crear_Trans(cnn)


            cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_CasetAsignaCliente_Insert")
            Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, Id_Caset)
            Crea_Parametro(cmd, "@Id_Cliente_Asignado", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Crea_Parametro(cmd, "@Usuario_Asigna", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Fecha_Asigna", SqlDbType.Date, Fecha)
            Crea_Parametro(cmd, "@Estacion_Asigna", SqlDbType.VarChar, EstacioN)
            EjecutarNonQueryT(cmd)

            cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Kardex_Caset_UpdateAsignado")
            Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, Id_Caset)
            Crea_Parametro(cmd, "@Id_Cliente_Asignado", SqlDbType.Int, Id_Cliente)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "AC")
            EjecutarNonQueryT(cmd)

            tr.Commit()
        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function





    Public Shared Function fn_Kardex_CasetAsignaCliente_Cancelar(ByVal lsv As cp_Listview, ByVal Descripcion As String) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        cnn = Crea_ConexionSTD()

        Try
            For Each item As ListViewItem In lsv.CheckedItems

                cmd = Crea_Comando("Kardex_CasetAsignaCliente_UpdateCancela", CommandType.StoredProcedure, cnn)
                Crea_Parametro(cmd, "@Id_Asignacion", SqlDbType.Int, item.Tag)
                Crea_Parametro(cmd, "@Id_Caset", SqlDbType.Int, item.SubItems(6).Text)
                Crea_Parametro(cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion_Cancela", SqlDbType.VarChar, UsuarioN)
                Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
                EjecutarNonQuery(cmd)
            Next

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function
#End Region

#Region "ENVASES"

    Public Shared Function fn_DevolucionResguardoLlenalistaEnvase(ByVal lsv As cp_Listview, ByVal CajaBancaria As Integer, ByVal TipoP As Integer) As DataTable
        Try
            Dim dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetDevolucionResguardoEnvase", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@TipoP", SqlDbType.Int, TipoP)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_CajaBancaria", SqlDbType.Int, CajaBancaria)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            dt = EjecutaConsulta(Cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_DevolucionMateriales_LlenarListaEnvase(ByRef lsv As cp_Listview, ByRef CS As ListViewColumnSorter) As DataTable

        Try
            Dim dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_MaterialGetEnvase", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Material", SqlDbType.VarChar, "S")
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            dt = EjecutaConsulta(Cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_DevolucionDotacion_LlenarListaEnvase(ByRef lsv_Catalogo As cp_Listview) As DataTable

        Try
            Dim dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetDevolucionDotacionEnvase", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            dt = EjecutaConsulta(Cmd)
            Return dt

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_DevolucionDotacion_LlenarListaProEnvase(ByRef lsv_Catalogo As cp_Listview, ByVal Tipo As Char) As DataTable
        Try
            Dim dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Bo_Boveda_GetDevolucionDotacionProcesoEnvase", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.VarChar, Tipo)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            dt = EjecutaConsulta(Cmd)
            Return dt

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioProceso_LlenarListaNewEnvases(ByVal lsv As cp_Listview, ByVal Destino As Char) As DataTable
        Try
            Dim dt As DataTable
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_LotesRecProceso_GetEnvases", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Destino", SqlDbType.VarChar, Destino) 'new 26/05/14 depto destino(M=Morralla ó P=Proceso<-default)

            dt = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CancelarEnvioCajeros_LlenarDetallesEnvases(ByVal lsv As cp_Listview, ByVal Id_Lote As Integer) As DataTable
        Try
            Dim dt As DataTable
            Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_LotesRemisionesD_GetCajerosEnvases", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@ID_Lote", SqlDbType.Int, Id_Lote)

            dt = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Remision digital"
    'Public Shared Function fn_Buscar_RxE(ByVal Envase As String, ByVal fecha As String) As DataTable

    '    Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Buscar_RxE", CommandType.StoredProcedure, Cnn)

    '    Cn_Datos.Crea_Parametro(Cmd, "@Envase", SqlDbType.VarChar, Envase)
    '    Cn_Datos.Crea_Parametro(Cmd, "@Fecha", SqlDbType.VarChar, fecha)

    '    Try
    '        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
    '        If Tbl.Rows.Count = 0 Then
    '            Return Nothing
    '        Else
    '            Return Tbl
    '        End If
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function
    'Public Shared Function fn_Guardar_RxE(ByVal Numero As String, ByVal Cant As Integer, ByVal Cant_scan As Integer) As Boolean

    '    Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Agregar_env", CommandType.StoredProcedure, Cnn)

    '    Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Numero)
    '    Cn_Datos.Crea_Parametro(Cmd, "@Cant", SqlDbType.Int, Cant)
    '    Cn_Datos.Crea_Parametro(Cmd, "@Cant_scan", SqlDbType.Int, Cant_scan)
    '    Try
    '        Return EjecutarNonQuery(Cmd)            
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try

    'End Function
    'Public Shared Function fn_Get_RxECant(ByVal Numero As String) As String

    '    Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Get_RxECant", CommandType.StoredProcedure, Cnn)
    '    Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Numero)
    '    Try
    '        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
    '        If Tbl.Rows.Count = 0 Then
    '            Return Nothing
    '        Else
    '            Return Tbl.Rows(0)(0).ToString()
    '        End If
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function
    'Public Shared Function fn_Delete_RxECant(ByVal Numero As String) As Boolean

    '    Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Delete_RxECant", CommandType.StoredProcedure, Cnn)

    '    Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, Numero)
    '    Try
    '        Return EjecutarNonQuery(Cmd)
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try

    'End Function

    ''Numero de remision Automatico
    ''>>
    Public Shared Function fn_VerificarNr(ByVal Clave_cliente As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        'Dim Cmd As SqlCommand = Crea_Comando("Nremision_P1", CommandType.StoredProcedure, Cnn)
        'Crea_Parametro(Cmd, "@ClaveC", SqlDbType.VarChar, Clave_cliente)
        Dim Cmd As SqlCommand = Crea_Comando("ComprobarNumeroRemision", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.VarChar, Clave_cliente)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_NumeroR(ByVal Clave_cliente As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        'Dim Cmd As SqlCommand = Crea_Comando("Nremision", CommandType.StoredProcedure, Cnn)
        'Crea_Parametro(Cmd, "@ClaveC", SqlDbType.VarChar, Clave_cliente)
        Dim Cmd As SqlCommand = Crea_Comando("NumeroRemisionNew", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.VarChar, Clave_cliente)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function
    Public Shared Function fn_RegresarSta(ByVal Clave_mat As Integer) As Integer
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Des_Remision_P1", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Libre", SqlDbType.Int, Clave_mat)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_Des_Remision(ByVal Clave_cliente As String, ByVal numero As Integer) As Integer
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        'Dim Cmd As SqlCommand = Crea_Comando("Insert_Rtemporal", CommandType.StoredProcedure, Cnn)
        Dim Cmd As SqlCommand = Crea_Comando("NumeroRemisionTmp", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_C", SqlDbType.VarChar, Clave_cliente)
        Crea_Parametro(Cmd, "@Numero", SqlDbType.VarChar, numero)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_deleteT(ByVal Clave As Integer) As Integer
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Eliminar_Rtemporal", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@id", SqlDbType.Int, Clave)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EnvasesXremision(ByVal lsv As cp_Listview, ByVal ruta As Integer, ByVal Fecha As Date) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        'Dim Cmd As SqlCommand = Crea_Comando("Nremision", CommandType.StoredProcedure, Cnn)
        'Crea_Parametro(Cmd, "@ClaveC", SqlDbType.VarChar, Clave_cliente)
        Dim Cmd As SqlCommand = Crea_Comando("EnvasesXRemision", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, ruta)
        Crea_Parametro(Cmd, "@Fecha_Entrada", SqlDbType.VarChar, FuncionesGlobales.fn_Fecha102(Fecha.ToShortDateString()))
        'MessageBox.Show(FuncionesGlobales.fn_Fecha102(Fecha.ToShortDateString).ToString)
        Try
            Dt = EjecutaConsulta(Cmd)
            lsv.Actualizar(Cmd, "Id_Remision")
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_EnvasesXremisionAtm(ByVal lsv As cp_Listview, ByVal ruta As Integer, ByVal Fecha As Date) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("EnvasesXRemision2", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Salida", SqlDbType.DateTime, Fecha.ToShortDateString)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Remision")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EnvasesXremisionMat(ByVal lsv As cp_Listview, ByVal ruta As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Get_envasesMat", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, ruta)                
        Try
            Dt = EjecutaConsulta(Cmd)
            lsv.Actualizar(Cmd, "Id_Remision")
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_RecRutasPropiasLlenalistaEnvasesAtms(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            'Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Caj_Puntos_GetRemaAtms", CommandType.StoredProcedure, Cnn)
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Caj_Puntos_GetRemaAtmsNew", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)
            lsv.Actualizar(Cmd, "")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiasLlenalistaEnvasesAtmsFallas(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            'Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Caj_Fallas_GetRemXenvases", CommandType.StoredProcedure, Cnn)
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Caj_Fallas_GetRemXenvasesNew", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)
            lsv.Actualizar(Cmd, "")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RecRutasPropiastvEnvases(ByVal lsv As cp_Listview, ByVal ID_programacion As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            'Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Tv_Puntos_GetRemisionesXE", CommandType.StoredProcedure, Cnn)
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Tv_Puntos_GetRemisionesXENew", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, ID_programacion)
            lsv.Actualizar(Cmd, "")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DespachoListaE(ByRef Lista As ds_Despacho.tbl_ListaDDataTable, ByVal Id_Despacho As Integer) As Boolean
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Bo_Despacho_Liste", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Despacho", SqlDbType.Int, Id_Despacho)
        Try
            cmd.Connection.Open()
            Lista.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DespachoMaterialesLlenalista(ByVal lsv As cp_Listview, ByVal ruta As Integer, ByVal Fecha As Date, ByVal Id_Programacion As Integer) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand
            'Cmd = Cn_Datos.Crea_Comando("Bo_Boveda_GetMat", CommandType.StoredProcedure, Cnn)
            Cmd = Cn_Datos.Crea_Comando("Bo_Boveda_GetMatNew", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Ruta_Salida", SqlDbType.Int, ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_programacion", SqlDbType.Int, Id_Programacion)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha", SqlDbType.DateTime, Fecha)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Boveda", SqlDbType.VarChar, BovedaTipo)

            'Aqui se Actualiza la lista
            With lsv
                .Actualizar(Cmd, "Id_Bo")
                .Columns(2).TextAlign = HorizontalAlignment.Right
                .Columns(3).TextAlign = HorizontalAlignment.Right
                .Columns(4).TextAlign = HorizontalAlignment.Right
                .Columns(5).TextAlign = HorizontalAlignment.Right
            End With
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Get_Envases2(ByVal lsv As cp_Listview, ByVal Id_Lote As Integer) As Boolean
        Try
            Dim cmd As SqlCommand = Crea_Comando("Cat_Envases_Get9New", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Lote", SqlDbType.Int, Id_Lote)

            lsv.Actualizar(cmd, "Id_Envase")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function
    Public Shared Function fn_Cliente_Padre(ByVal Id_Cliente As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Cliente_Padre_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Cliente", SqlDbType.Int, Id_Cliente)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function


    'Public Shared Function fn_TvNumeroRemision(ByVal Id_punto As Integer) As DataTable
    '    Dim Dt As DataTable
    '    Dim Cnn As SqlConnection = Crea_ConexionSTD()
    '    'Dim Cmd As SqlCommand = Crea_Comando("Nremision", CommandType.StoredProcedure, Cnn)
    '    'Crea_Parametro(Cmd, "@ClaveC", SqlDbType.VarChar, Clave_cliente)
    '    Dim Cmd As SqlCommand = Crea_Comando("RemisionGerera_Get", CommandType.StoredProcedure, Cnn)
    '    Crea_Parametro(Cmd, "@Id_Punto", SqlDbType.Int, Id_punto)
    '    Try
    '        Dt = EjecutaConsulta(Cmd)
    '        Return Dt
    '    Catch ex As Exception
    '        TrataEx(ex, True)
    '        Return Nothing
    '    End Try
    'End Function

    'Generear numero de remision PDF
    Public Shared Function obtenerNotificacion(ByVal NumeroRemision As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Buscar_RemisionDigital", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Numero_Remision", SqlDbType.VarChar, NumeroRemision)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function obtenerRemisionWebImporte(ByVal NumeroRemision As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("NotificacionImportesWebTraslado", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@NumeroRemision", SqlDbType.VarChar, NumeroRemision)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function obtenerEnvases(ByVal NumeroRemision As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("NotificacionEnvasesTraslado", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@NumeroRemision", SqlDbType.VarChar, NumeroRemision)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function obtenerImporteMoneda(ByVal NumeroRemision As String) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("NotificacionMonedaTraslado", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@NumeroRemision", SqlDbType.VarChar, NumeroRemision)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function obtenerEnvases(ByVal dtEnvases As DataTable) As String
        Dim envases As String = String.Empty

        For Each envase As DataRow In dtEnvases.Rows
            envases += "[" & envase("Numero").ToString() & "]"
        Next

        Return envases
    End Function
    Public Shared Function obtenerEnvaseMoneda(ByVal dtEnvases As DataTable) As Integer
        Return (From envase In dtEnvases.AsEnumerable() Where CStr(envase("Tipo Envase")) = "BILLETE" Select envase).Count()
    End Function

    Public Shared Function obtenerEnvaseMixto(ByVal dtEnvases As DataTable) As Integer
        Return (From envase In dtEnvases.AsEnumerable() Where CStr(envase("Tipo Envase")) = "MIXTO" Select envase).Count()
    End Function

    Public Shared Function obtenerEnvaseMorralla(ByVal dtEnvases As DataTable) As Integer
        Return (From envase In dtEnvases.AsEnumerable() Where CStr(envase("Tipo Envase")) = "MORRALLA" Select envase).Count()
    End Function
    Public Shared Function obtenerMonenadaNacional(ByVal datos As DataTable) As Decimal
        Dim monedaNacional As Decimal = 0

        For Each moneda As DataRow In datos.Rows
            If moneda("Moneda").ToString() = "PESOS" Then monedaNacional += Convert.ToDecimal(moneda("Efectivo"))
        Next

        Return monedaNacional
    End Function

    Public Shared Function obtenerMonedaExtranjera(ByVal datos As DataTable) As Decimal
        Dim monedaExt As Decimal = 0

        For Each moneda As DataRow In datos.Rows
            If moneda("Moneda").ToString() <> "PESOS" Then monedaExt += Convert.ToDecimal(moneda("Efectivo")) * Convert.ToDecimal(moneda("Tipo Cambio"))
        Next

        Return monedaExt
    End Function

    Public Shared Function obtenerDocumentos(ByVal datos As DataTable) As Decimal
        Dim doc As Decimal = 0

        For Each moneda As DataRow In datos.Rows
            doc += Convert.ToDecimal(moneda("Documentos"))
        Next

        Return doc
    End Function
    Public Shared Function fn_SubCliente_LlenarLista(ByVal Id_Padre As Integer, ByVal Status As String, ByVal AgregarPadre As Boolean) As DataTable
        Try

            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Obtener_SubClientes", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Cliente", SqlDbType.Int, Id_Padre)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            If AgregarPadre Then Crea_Parametro(cmd, "@AgregarPadre", SqlDbType.VarChar, "S")

            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function
    'Cambiar Origen 
    Public Shared Function Nuevo_Origen(ByVal Id_Bo As Decimal, ByVal Id_NuevoOrigen As Integer) As Integer
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("NuevoOrigenCustodias", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Bo", SqlDbType.Decimal, Id_Bo)
        Crea_Parametro(Cmd, "@NuevoOrigen", SqlDbType.Int, Id_NuevoOrigen)
        'Crea_Parametro(Cmd, "@id", SqlDbType.Int, Clave)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_ListClientes() As DataTable
        Try

            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesTodos", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Return EjecutaConsulta(cmd)
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function
#End Region
End Class