'Imports de sistema
Imports System.IO
Imports System.Threading
Imports Microsoft.VisualBasic.Devices
'Imports de Telegram bot
Imports Telegram.Bot
Imports Telegram.Bot.Types.InputFiles
Imports Telegram.Bot.Types.ReplyMarkups

Public Class Form1

#Region "Variables"
    'Varibales utilizadas para funciones de telegram
    Public Token = "TOKEN DEL BOT AQUI" ' Token del BOT recuerda nunca compartir XD
    Public OwnerID = "TELEGRAM USER ID AQUI" 'Aqui va el telgram id del dueño, lo utilizo para comandos de administracion
    Public bot As New Telegram.Bot.TelegramBotClient(Token)
    Public update_id As Integer = 0
    'Variables utilizadas en la parte de saber info de la RAM
    Public inf As String
    Public x As Process
    Public k As Integer = 0

#End Region

#Region "Proceso principal para funcionamiento del bot"
    Private Async Sub Bot_CheckAsync()
        'Obtenemos los updates del telegram (mensajes nuevos)
        Try
            Dim bot_updates = bot.GetUpdatesAsync(update_id + 1).Result
            'Comprobamos que haya nuevos mensajes
            If bot_updates.Length > 0 Then
                'una vez tenida la cantidad de mensajes empezamos a analizarlos
                For i = 0 To bot_updates.Length - 1
                    update_id = bot_updates(i).Id

                    'Obtener info de botones <<<=========================================================== OBTENER INFO BOTONES PROXIMANTE
                    'If bot_updates(0).CallbackQuery.Data.ToString = "TEXTO PAR COMPARAR Y ACTIVAR" Then
                    ' Await bot.SendTextMessageAsync("TELEGRAM ID", "Funciona :)")
                    'End If

                    'Aqui revisamos si el mensaje recibido es texto u otro tipo de mensaje
                    If bot_updates(0).Message.Type.ToString = "TextMessage" Then
                        'Aqui por debug obtenermos el id y el nombre de usuario de quien envio el mensaje y lo ponemos en la listbox1
                        SetText_ListBox1(bot_updates(0).Message.From.Id & " / " & bot_updates(0).Message.From.Username & " / " & bot_updates(0).Message.Text)
                    Else
                        SetText_ListBox1(bot_updates(0).Message.From.Id & " / " & bot_updates(0).Message.From.Username & " / " & bot_updates(0).Message.Type.ToString())
                    End If
                    'Comprobamos que el chat sea un grupo para asi separar los mensajes privados de los de grupo
                    If UCase(bot_updates(0).Message.Chat.Type.ToString) = "GROUP" Then
                        If UCase(bot_updates(0).Message.Text) = "HOLA" Then
                            Await bot.SendChatActionAsync(bot_updates(0).Message.Chat.Id, Types.Enums.ChatAction.Typing)
                            Await bot.SendTextMessageAsync(bot_updates(0).Message.Chat.Id, "Hola al grupo " & bot_updates(0).Message.From.FirstName, False, False)
                        End If
                    Else 'Aqui es donde pondremo los comandos para el chat privado
                        If UCase(bot_updates(0).Message.Text) = "/START" Then
                            Await bot.SendChatActionAsync(bot_updates(0).Message.From.Id, Types.Enums.ChatAction.Typing)
                            Await bot.SendTextMessageAsync(bot_updates(0).Message.From.Id, "Bienvenido " & bot_updates(0).Message.From.FirstName, False, False)
                            Await bot.SendChatActionAsync(bot_updates(0).Message.From.Id, Types.Enums.ChatAction.Typing)
                            Await bot.SendTextMessageAsync(bot_updates(0).Message.From.Id, "/AYUDA - Muestra este mensaje /HOLA - Comando de pruebas /GIF - Envia una imagen gif de prueba /RAM - Envia informacion sobre la ram utilizada por la app /PCRAM - Envia informacion sobre la RAM del equipo /BOTONES - Muestra Ejemplo del uso de botones", 2, False)
                        End If
                        If UCase(bot_updates(0).Message.Text) = "/AYUDA" Then
                            Await bot.SendChatActionAsync(bot_updates(0).Message.Chat.Id, Types.Enums.ChatAction.Typing)
                            Await bot.SendTextMessageAsync(bot_updates(0).Message.From.Id, "/AYUDA - Muestra este mensaje /HOLA - Comando de pruebas /GIF - Envia una imagen gif de prueba /RAM - Envia informacion sobre la ram utilizada por la app /PCRAM - Envia informacion sobre la RAM del equipo /BOTONES - Muestra Ejemplo del uso de botones", 2, False)
                        End If
                        If UCase(bot_updates(0).Message.Text) = "HOLA" Then
                            Await bot.SendChatActionAsync(bot_updates(0).Message.From.Id, Types.Enums.ChatAction.Typing)
                            Await bot.SendTextMessageAsync(bot_updates(0).Message.From.Id, "HOLA " & bot_updates(0).Message.From.FirstName, False, False)
                        End If
                        If UCase(bot_updates(0).Message.Text) = "/HOLA" Then
                            Await bot.SendChatActionAsync(bot_updates(0).Message.From.Id, Types.Enums.ChatAction.Typing)
                            Await bot.SendTextMessageAsync(bot_updates(0).Message.From.Id, "HOLA " & bot_updates(0).Message.From.FirstName, False, False)
                        End If
                        '======== ENVIAR ARCHIVOS ==============
                        If UCase(bot_updates(0).Message.Text) = "/GIF" Then
                            Dim documento As InputOnlineFile = New InputOnlineFile(IO.File.Open("giphy.mp4", FileMode.Open, FileAccess.Read, FileShare.Read))
                            'documento.FileName = "Nombre del archivo"
                            Await bot.SendChatActionAsync(bot_updates(0).Message.From.Id, Types.Enums.ChatAction.UploadVideo)
                            Await bot.SendVideoAsync(bot_updates(0).Message.From.Id, documento)
                        End If
                        'Verificamos la ram utilizada y disponible de la computadora donde se esta ejecutando la apliacion
                        If UCase(bot_updates(0).Message.Text) = "/PCRAM" Then
                            Dim CI As New ComputerInfo()
                            Dim avl, used As String
                            Dim mem As ULong = ULong.Parse(CI.AvailablePhysicalMemory.ToString())
                            Dim mem1 As ULong = ULong.Parse(CI.TotalPhysicalMemory.ToString()) - ULong.Parse(CI.AvailablePhysicalMemory.ToString())
                            avl = (mem / (1024 * 1024) & " MB").ToString()
                            used = (mem1 / (1024 * 1024) & " MB").ToString()
                            Await bot.SendChatActionAsync(bot_updates(0).Message.From.Id, Types.Enums.ChatAction.Typing)
                            Await bot.SendTextMessageAsync(bot_updates(0).Message.From.Id, "Memoria del sistema en uso " & used & vbCrLf _
                            & "Disponible " & avl, False, False)
                            SetText_ListBox2("Memoria del sistema en uso " & used & " de " & avl)
                        End If
                        'Aqui verificamos la ram utilizada por la aplicacion unicamente
                        If UCase(bot_updates(0).Message.Text) = "/RAM" Then
                            x = Process.GetCurrentProcess()
                            inf = "Memoria Utilizada: " & x.WorkingSet64 / 1024 & " K" & vbCrLf _
                            & "Memoria paginada: " & x.PagedMemorySize64 / 1024 & " K"
                            SetText_ListBox2(inf)
                            Await bot.SendChatActionAsync(bot_updates(0).Message.From.Id, Types.Enums.ChatAction.Typing)
                            Await bot.SendTextMessageAsync(bot_updates(0).Message.From.Id, "La aplicacion esta utilizando los siguientes recursos" & vbCrLf _
                            & inf, False, False)
                        End If
                        'Aqui probamos los botones
                        If UCase(bot_updates(0).Message.Text) = "/BOTONES" Then
                            Await bot.SendChatActionAsync(bot_updates(0).Message.From.Id, Types.Enums.ChatAction.Typing)

                            'Contruimos los botones para despues utilizarlos
                            Dim bt2 As InlineKeyboardButton = New InlineKeyboardButton With {
                            .Text = "Test",
                            .CallbackData = "Test"
                            }
                            Dim bt3 As InlineKeyboardButton = New InlineKeyboardButton With {
                            .Text = "Test 2",
                            .CallbackData = "test2"
                            }
                            'Tambien puede ser en una sola linea al crear los botones
                            Dim bt4 As InlineKeyboardButton = New InlineKeyboardButton With {.Text = "Test 3", .CallbackData = "test3"}
                            Dim bt5 As InlineKeyboardButton = New InlineKeyboardButton With {.Text = "Test 4", .CallbackData = "test4"}

                            'Mostraamos el teclado de esta forma cuando son pocos botones
                            'Dim teclado As InlineKeyboardMarkup = New InlineKeyboardMarkup({bt2, bt3, bt4, bt5})

                            'Mostraamos el teclado de esta forma cuando son varios botones
                            Dim teclado As InlineKeyboardMarkup = New InlineKeyboardButton()() {
                            New InlineKeyboardButton() {bt2},
                            New InlineKeyboardButton() {bt3, bt4},
                            New InlineKeyboardButton() {bt2, bt3, bt4, bt5}
                            }

                            Await bot.SendTextMessageAsync(bot_updates(0).Message.From.Id, "Elige un boton pero aun no hacen anda xD " & bot_updates(0).Message.From.FirstName, replyMarkup:=teclado)
                        End If
#Region "Administracion"

                        If UCase(bot_updates(0).Message.Text) = "CERRAR APP" Then
                                'comprobamos que dueno del bot haya echo la peticion para evitar que cualquiera cierre el programa
                                If UCase(bot_updates(0).Message.From.Id.ToString) = OwnerID Then
                                    Await bot.SendChatActionAsync(bot_updates(0).Message.From.Id, Types.Enums.ChatAction.Typing)
                                    Await bot.SendTextMessageAsync(bot_updates(0).Message.From.Id, "Cerrando Aplicacion ", False, False)
                                    Environment.Exit(0)
                                    Environment.FailFast("")
                                End If
                            End If
                            If UCase(bot_updates(0).Message.Text) = "REINICIAR APP" Then
                                If UCase(bot_updates(0).Message.From.Id.ToString) = OwnerID Then
                                    Await bot.SendChatActionAsync(bot_updates(0).Message.From.Id, Types.Enums.ChatAction.Typing)
                                    Await bot.SendTextMessageAsync(bot_updates(0).Message.From.Id, "Reiniciando Aplicacion ", False, False)
                                    Application.Restart()
                                End If
                            End If
                        End If
#End Region
                        ' llamamos al método SetText para enviar la informacion al label debug
                        SetText_Lbl_Debug_Info(i)
                Next
            End If
            ' Wait 1 second.
            Thread.Sleep(1000)

            'Vaciamos esta variables tranto de evitar algunos bugs
            bot_updates = Nothing
            Await bot.DeleteWebhookAsync()
        Catch ex As Exception
            'tratar de cachar los errores
            SetText_ListBox2(ex.Message)
            'damos un pequeno respiro al programa
            Thread.Sleep(100)
            Application.ExitThread()
            Exit Sub
        End Try
    End Sub
#End Region

#Region "Activando Aplicacion"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hacemos que este proceso inice en un segundo hilo evitando que el gui se frezzee
        BackgroundWorker1.RunWorkerAsync()
        'Nos posicionamos en el campo de ID solo para saber donde esta el cursor al inciiar la app
        Txt_ID_Test.Select()
        Txt_ID_Test.Focus()
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Llamamos a un loop constante para asi obtener los updates de telegram y poder responder lo mas rapido posible
        Call iniciar_loop_infinito_botcheck()
    End Sub

    Private Sub iniciar_loop_infinito_botcheck()
        Dim O As Integer = 0
        While True
            Try
                'Cargamos el bot
                Bot_CheckAsync()
                'Tratamos de limpiar la ram lo mas que podamos 
                LiberarMemoria()
                'tratando de ver cuantos hilos hay activos
                Dim proc As Process = Process.GetCurrentProcess()
                SetText_Lbl_Debug_Info(proc.Threads.Count.ToString())
            Catch ex As Exception
                'tratar de cachar los errores
                SetText_ListBox2(ex.Message)
            End Try
        End While
    End Sub

#End Region

#Region "Pasar texto de un hilo a otro"
    'Label Debug
    ' Usando delegados y funciones "callback"
    '
    ' Este delegado define un método Sub
    ' que recibe un parámetro de tipo String
    Delegate Sub SetTextCallback(ByVal text As String)

    Private Sub SetText_Lbl_Debug_Info(ByVal text As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Lbl_Debug_Info.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText_Lbl_Debug_Info)
            Me.Invoke(d, New Object() {text})
        Else
            Me.Lbl_Debug_Info.Text = text
        End If
    End Sub

    'ListBox1
    Delegate Sub SetText_ListBox1Callback(ByVal text As String)

    Private Sub SetText_ListBox1(ByVal text As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If ListBox1.InvokeRequired Then
            Dim d As New SetText_ListBox2Callback(AddressOf SetText_ListBox1)
            Me.Invoke(d, New Object() {text})
        Else
            Me.ListBox1.Items.Add(text)
        End If
    End Sub

    'ListBox2
    Delegate Sub SetText_ListBox2Callback(ByVal text As String)

    Private Sub SetText_ListBox2(ByVal text As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If ListBox2.InvokeRequired Then
            Dim d As New SetText_ListBox2Callback(AddressOf SetText_ListBox2)
            Me.Invoke(d, New Object() {text})
        Else
            Me.ListBox2.Items.Add(text)
        End If
    End Sub

#End Region

#Region "Proceso para liberar Ram"
    '+++++++++++ Intentatando Liberar Memoria RAM +++++++++++++++++
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean
    Public Sub LiberarMemoria()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If Environment.OSVersion.Platform = PlatformID.Win32NT Then
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1)
                Dim myProcesses As Process() = (Process.GetProcessesByName("juanruiz85_bot"))
                Dim myProcess As Process
                For Each myProcess In myProcesses
                    SetProcessWorkingSetSize(myProcess.Handle, -1, -1)
                Next myProcess
            End If
        Catch ex As Exception
            'tratar de cachar los errores
            SetText_ListBox2(ex.Message)
        End Try
    End Sub
#End Region

#Region "Test"
    'Aqui es para mandar mensajes directamente a un usuario de telegram teniendo su id
    Private Sub Btb_Test_Click(sender As Object, e As EventArgs) Handles Btb_Test.Click
        Try
            bot.SendChatActionAsync(Txt_ID_Test.Text, Types.Enums.ChatAction.Typing)
            bot.SendTextMessageAsync(Txt_ID_Test.Text, Txt_Text_Test.Text, False, False)

            'Agregamos a la lista de eventos el mensaje
            Me.ListBox2.Items.Add("Se envio el mensaje =>" & Txt_Text_Test.Text & "<= al ID =>" & Txt_ID_Test.Text & "<=")

            'Limpiamos la informacion y nos volvemos a posicionar en el textbox ID
            Txt_ID_Test.Text = ""
            Txt_Text_Test.Text = ""
            Txt_ID_Test.Select()
            Txt_ID_Test.Focus()

        Catch ex As Exception
            'Agregamos a la lista de eventos el mensaje
            Me.ListBox2.Items.Add("No se pudo enviar el mensaje " & Txt_Text_Test.Text & " al ID " & Txt_ID_Test.Text & " Error: " & ex.Message)
            'Limpiamos la informacion y nos volvemos a posicionar en el textbox ID
            Txt_ID_Test.Text = ""
            Txt_Text_Test.Text = ""
            Txt_ID_Test.Select()
            Txt_ID_Test.Focus()

        End Try
    End Sub

#End Region

End Class
