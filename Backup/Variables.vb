Module Variables
    Public MorrallaRecibeRuta As Boolean

    Public Cnx_Datos As String = ""
    Public ServDatos As String = ""
    Public BaseDatos As String = ""
    Public UsuarioDatos As String = ""
    Public ContraDatos As String = ""
    Public SucursalDatos As String = ""
    Public UsuarioId As Integer
    Public UsuarioN As String
    Public EmpresaId As Integer
    Public SucursalId As Integer
    Public SucursalN As String
    Public ProcesoD As Long
    Public EstacioN As String
    Public EstacionIp As String
    Public EstacionMac As String
    Public MonedaId As Integer
    Public ModuloClave As String
    Public ModuloNombre As String
    Public ModuloVersion As String
    Public ContraHash As String
    Public UsuarioTipo As Byte
    Public CiaId As Integer
    Public I As Integer
    Public J As Integer
    Public ResP As Integer
    Public BanderA As Boolean
    Public TurnoId As Integer
    Public DepartamentoID As Integer
    Public Mail_ReporteFallas As String

    Public CambiarConexion As Boolean
    Public CadenaPermisosControles As String

    Public LoginId As Long
    Public MinutosDesconexion As Integer 'Parametro de Cat_Sucursales
    Public SegundosDesconexion As Integer 'Contador de segundos para el Bloqueo
    Public TipoBloqueo As Byte '0=No Bloqueado; 1=Bloqueado por el Usuario; 2=Bloqueado por inactividad
    Public Intentos_Login As Byte

    Public BovedaTipo As Char  'C=Cajeros; P=Proceso; M=Morralla

    'Remisiones digitales
    Public Numero_env_aux As String
    Public List_Envases As New List(Of String)
    Public NumerosEAtms As New DataTable
    Public Copy_remision As String
    Public Id_matventa As Integer
    Public Id_puntomat As Integer
    'Public Remision As String '08/07/2021 

    'FACTURACION

    'Public Id_RemisionFacturacion As Integer
    'Public Id_Movimiento As Integer

End Module
