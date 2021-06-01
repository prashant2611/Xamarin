using SoldMachine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoldMachine.Services
{
    class FileList
    {
        List<AssetInfo> assets = new List<AssetInfo>()
        {
            new AssetInfo(1,"C300","Cutter head","S6"),
            new AssetInfo(2,"C40","Cutter head","S7"),
            new AssetInfo(3,"C300","Blade safety cover","S10"),
            new AssetInfo(4,"C60","Blade safety cover","S11"),
            new AssetInfo(5,"C300","Deburring blades","S6"),
            new AssetInfo(6,"C60","Cutter head","S8"),
            new AssetInfo(7,"C60","Clamping fixture","S2"),
            new AssetInfo(8,"C40","Blade safety cover","S11"),
            new AssetInfo(9,"C40","Shutter gripper","S3"),
            new AssetInfo(10,"C10","Shutter gripper","S4"),
            new AssetInfo(11,"C10","Cutter head","S2")

        };

        public List<AssetInfo> ReadFileContent()
        {
            return assets;
        }
    }
}
