using SoldMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoldMachine.Services
{
    class MachineDetailRepository: IMachineDetailRepository
    {
        private FileList _data = new FileList();
        private IEnumerable<AssetInfo> _assets;
        public MachineDetailRepository()
        {
            _assets = _data.ReadFileContent();
        }

        public List<string> GetAssetForMachineType(string machineName)
        {
            List<string> assetList = new List<string>();
            assetList = _assets.Where(x => x.machineName == machineName).Select(x => x.assetName).ToList();
            return assetList;
        }

        public List<string> GetMachineTypeForAsset(string assetName)
        {
            List<string> machineList = new List<string>();
            machineList = _assets.Where(x => x.assetName == assetName).Select(x => x.machineName).ToList();
            return machineList;
        }

        public List<string> GetMachineTypeUseLetestAsset()
        {
            List<string> useOldSeriesAsset = new List<string>();
            List<string> letestSeries = new List<string>();

            var maxAssetSeries = _assets.GroupBy(x => x.assetName)      //Finding letest asset
                                       .Select(grp => new
                                       {
                                           assetName = grp.Key,
                                           max = grp.Max(x => x.assetSeries)
                                       }).ToList();

            foreach (var Asset in _assets)                  //Finding Machines those uses old asset series
            {
                if (!(Asset.assetSeries == maxAssetSeries.Where(x => x.assetName == Asset.assetName).Select(x => x.max).FirstOrDefault()))
                {
                    useOldSeriesAsset.Add(Asset.machineName);
                }
            }

            foreach (var part in _assets.Select(x => x.machineName).ToList().Except(useOldSeriesAsset))
            {
                letestSeries.Add(part);
            }

            return letestSeries;
        }
    }
}
