

Module Module1
    'This program will chase up approvers to remind them to sent approve their teams reimbursements

  

    Sub Main(ByVal args() As String)
       

        If args.Count > 0 Then
            Dim ws1 As New [me].agapeconnect.DatatSync
            Dim password = From c In args Where c <> "-t"
            If password.Count > 0 Then
                If args.Contains("-t") Then
                    Console.Write("Testing")
                    Console.ReadKey(True)
                    Dim response1 = ws1.TriggerEmails(password.First)

                    Console.Write(response1 & vbNewLine)
                    Console.ReadKey(True)
                    Return
                Else
                    Dim response1 = ws1.TriggerEmails(password.First)

                    Console.Write(response1 & vbNewLine)
                End If
             
            Else
                Console.Write("You must Supply a password for the web service:" & vbNewLine & "Nagape {ENTER_PASSWORD_HERE}")
            End If


          
        Else


            Console.Write("Could not find password. Try one of the following:" & vbNewLine & "Nagape {ENTER_PASSWORD_HERE}")


        End If


        If args.Contains("-t") Then
            Console.ReadKey(True)
        End If








    End Sub


End Module
