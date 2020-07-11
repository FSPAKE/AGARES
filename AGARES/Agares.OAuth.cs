using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FSPAKE.AGARES.CoreSystem
{
    partial class Agares
    {
        private async Task<UserCredential> NewCredentialAsync(string filename)
        {
            if (!File.Exists(filename)) {
                UIManager.MessageBoxShow(
                filename + "が存在しません。マニュアルに従い該当ファイルを配置して下さい。"
                , "AGAERS", MessageBoxButtons.OK, MessageBoxType.Warning);
                return null;
            };
            return await OAuthManager.GetCredential(filename).ConfigureAwait(true);
        }
    }
}
