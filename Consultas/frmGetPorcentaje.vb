Public Class frmGetPorcentaje

    Private Sub cmbOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        If Length(ntxPorcIncrDecrPerido.Value) = 0 Then
            If ExpertisApp.GenerateMessage("No ha seleccionado un {0}. El proceso se cancelará.", MessageBoxButtons.YesNo, MessageBoxIcon.Information, lblPorcIncrDecrPerido.Text) = Windows.Forms.DialogResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If

        ElseIf ExpertisApp.GenerateMessage("Ha seleccionado un {0}% de {1}.{2}¿Desea actualizar los registros selecciondados con dicho valor?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, ntxPorcIncrDecrPerido.Value, Trim(Replace(lblPorcIncrDecrPerido.Text, "%", "")), vbNewLine) = Windows.Forms.DialogResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class