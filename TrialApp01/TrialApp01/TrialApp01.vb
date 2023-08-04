''' <summary>
''' TrialApp01モジュール
''' </summary>
''' <remarks>メインモジュール</remarks>
Module TrialApp01
    ''' <summary>
    ''' スタートアップ処理
    ''' </summary>
    ''' <remarks></remarks>
    Sub Main()
        With New BusinessClass
            Console.WriteLine(.GetMessage & Environment.NewLine & .GetToday.ToString("yyyy-MM-dd"))
        End With

        Call Console.ReadLine()

    End Sub

End Module
