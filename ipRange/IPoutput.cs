using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ipRange
{
    /// <summary>
    /// Класс работы с IP адресами
    /// </summary>
    class IPoutput
    {
        /// <summary>
        /// Проверка IP
        /// </summary>
        public bool CheckIpAddress(string ipAddress)
        {
            IPAddress ip;
            bool b = IPAddress.TryParse(ipAddress, out ip);

            return b;
        }

        /// <summary>
        /// Добавить IP в список
        /// </summary>
        public List<IPstructure> AddIp(string ipString, List<IPstructure> ipList)
        {
            if (CheckIpAddress(ipString))
            {
                var reg = Regex.Matches(ipString, @"[0-9]+");
                
                ipList.Add(new IPstructure() { FullIpAddress = ipString, FirstPart = int.Parse(reg[0].Value), SecondPart = int.Parse(reg[1].Value), ThirdPart = int.Parse(reg[2].Value), FourthPart = int.Parse(reg[3].Value) });
            }
            return ipList;
        }

        /// <summary>
        /// Поиск IP
        /// </summary>
        public List<IPstructure> FindIp(string ipString, List<IPstructure> ipList)
        {
            List<IPstructure> result = new List<IPstructure>();
            var reg = Regex.Matches(ipString, @"[0-9]+");
            result = ipList;
            if (reg[0].Value != "0")
            {
                result = result.FindAll(x => x.FirstPart == int.Parse(reg[0].Value));
            }

            if (reg[1].Value != "0")
            {
                result = result.FindAll(x => x.SecondPart == int.Parse(reg[1].Value));
            }
            if (reg[2].Value != "0")
            {
                result = result.FindAll(x => x.ThirdPart == int.Parse(reg[2].Value));
            }
            if (reg[3].Value != "0")
            {
                result = result.FindAll(x => x.FourthPart == int.Parse(reg[3].Value));
            }

            return result;
        }
    }
}
