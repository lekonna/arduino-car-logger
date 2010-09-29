Imports System.IO.Ports


Public Class Form1
    Public Delegate Sub StringSubPointer(ByVal Buffer As String)
    Dim WithEvents COMPort As New SerialPort
    Dim values(7) As String
    Dim logging As Boolean
    Dim line_counter As Integer
    Dim file_buffer As String


    Private Sub Receiver(ByVal sender As Object, _
           ByVal e As SerialDataReceivedEventArgs) Handles COMPort.DataReceived
        If COMPort.IsOpen Then
            Me.BeginInvoke(New StringSubPointer(AddressOf Display), COMPort.ReadLine)
        End If
    End Sub

    Private Sub Display(ByVal Buffer As String)
        'Received.AppendText(Buffer)
        'Received.Text = Buffer
        values = Split(Buffer)
        'Status.Text = values.Length
        If values.Length = 6 Then


            rpm.Text = values(1)
            If Val(values(1)) > Val(rpm_max.Text) Then rpm_max.Text = values(1)
            If Val(values(1)) < Val(rpm_min.Text) Then rpm_min.Text = values(1)

            If (Val(values(1)) > rpm_bar.Minimum) And (Val(values(1)) < rpm_bar.Maximum) Then
                rpm_bar.Value = Val(values(1))
            End If
            afr.Text = values(2)
            If Val(values(2)) > Val(afr_max.Text) Then afr_max.Text = values(2)
            If Val(values(2)) < Val(afr_min.Text) Then afr_min.Text = values(2)

            If Val(values(2)) < 148 Then
                afr.ForeColor = Color.Green
            End If
            If Val(values(2)) < 110 Then
                afr.ForeColor = Color.Blue
            End If
            If Val(values(2)) > 148 Then
                afr.ForeColor = Color.Red
            End If
            If (Val(values(2)) > afr_bar.Minimum) And (Val(values(2)) < afr_bar.Maximum) Then
                afr_bar.Value = Val(values(2))
            End If
            maf.Text = values(3)
            If Val(values(3)) > Val(maf_max.Text) Then maf_max.Text = values(3)
            If Val(values(3)) < Val(maf_min.Text) Then maf_min.Text = values(3)

            map.Text = values(4)
            If Val(values(4)) > Val(map_max.Text) Then map_max.Text = values(4)
            If Val(values(4)) < Val(map_min.Text) Then map_min.Text = values(4)

            egt.Text = values(5)
            If Val(values(5)) > Val(egt_max.Text) Then egt_max.Text = values(5)
            If Val(values(5)) < Val(egt_min.Text) Then egt_min.Text = values(5)

            mgc.Text = Int(Val(values(3)) * 30 * 1000 / Val(values(1)))

            If Val(mgc.Text) > Val(mgc_max.Text) Then mgc_max.Text = mgc.Text
            If Val(mgc.Text) < Val(mgc_min.Text) Then mgc_min.Text = mgc.Text

            If logging Then
                line_counter = line_counter + 1
                file_buffer = file_buffer + Buffer
                If line_counter > 20 Then
                    line_counter = 0
                    My.Computer.FileSystem.WriteAllText(Received.Text, file_buffer, True)
                    file_buffer = ""
                End If
            End If
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Status.Text = "connecting"

        COMPort.PortName = "COM6"
        COMPort.BaudRate = 19200
        COMPort.ReadTimeout = 2000
        Status.Text = "connected"
        Status.ForeColor = Color.Green
        afr_bar.Maximum = 223
        afr_bar.Minimum = 73
        Try
            COMPort.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            Status.Text = "fail!"
            Status.ForeColor = Color.Red
        End Try


    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        COMPort.Close()
        Status.Text = "Closed"
        Status.ForeColor = Color.Black
    End Sub


    Private Sub Form1_closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        COMPort.Close()
        Status.Text = "Closed"
        Status.ForeColor = Color.Black
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If logging Then
            logging = False
            Button3.Text = "Start Log"
        Else
            logging = True
            Button3.Text = "Stop Log"
            Try
                My.Computer.FileSystem.WriteAllText(Received.Text, "New log:" + DateAndTime.DateString, True)
            Catch ex As Exception
                MsgBox(ex.Message)
                logging = False
                Button3.Text = "Start Log"
            End Try
        End If
    End Sub

    Private Sub min_max_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min_max_reset.Click
        afr_max.Text = "0"
        afr_min.Text = "223"
        rpm_min.Text = "10000"
        rpm_max.Text = "0"
        egt_max.Text = "0"
        egt_min.Text = "1200"
        map_max.Text = "0"
        map_min.Text = "999"
        maf_max.Text = "0"
        maf_min.Text = "999"
        mgc_max.Text = "0"
        mgc_min.Text = "999"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Received.Text = "c:\temp\log" + DateAndTime.DateString() + "_" + TimeString() + ".txt"

    End Sub
End Class
