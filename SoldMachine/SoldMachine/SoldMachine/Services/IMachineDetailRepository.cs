using System;
using System.Collections.Generic;
using System.Text;

namespace SoldMachine.Services
{
    interface IMachineDetailRepository
    {
        List<string> GetAssetForMachineType(string machineName);
        List<string> GetMachineTypeForAsset(string assetName);
        List<string> GetMachineTypeUseLetestAsset();
    }
}
