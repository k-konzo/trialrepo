''' <summary>
''' Businessクラス
''' </summary>
''' <remarks>業務クラス</remarks>
Public Class BusinessClass
    ''' <summary>
    ''' メッセージを返す
    ''' </summary>
    ''' <returns>メッセージ</returns>
    ''' <remarks></remarks>
    Public Overridable Function GetMessage() As String
        Return Me.GetType().Name
    End Function

End Class
