﻿using FormsDialogButtons = System.Windows.Forms.MessageBoxButtons;
using FormsDialogResult = System.Windows.Forms.DialogResult;

namespace SpiderEye.Windows.Interop
{
    internal static class WinFormsMapper
    {
        public static DialogResult MapResult(FormsDialogResult result)
        {
            switch (result)
            {
                case FormsDialogResult.OK:
                    return DialogResult.Ok;
                case FormsDialogResult.Cancel:
                    return DialogResult.Cancel;
                case FormsDialogResult.Yes:
                    return DialogResult.Yes;
                case FormsDialogResult.No:
                    return DialogResult.No;
                case FormsDialogResult.None:
                case FormsDialogResult.Abort:
                case FormsDialogResult.Retry:
                case FormsDialogResult.Ignore:
#if NET6_0_OR_GREATER
                case FormsDialogResult.TryAgain:
                case FormsDialogResult.Continue: 
#endif
                default:
                    return DialogResult.None;
            }
        }

        public static FormsDialogButtons MapButtons(MessageBoxButtons buttons)
        {
            switch (buttons)
            {
                case MessageBoxButtons.Ok:
                    return FormsDialogButtons.OK;
                case MessageBoxButtons.OkCancel:
                    return FormsDialogButtons.OKCancel;
                case MessageBoxButtons.YesNo:
                    return FormsDialogButtons.YesNo;
                default:
                    return FormsDialogButtons.OK;
            }
        }
    }
}
