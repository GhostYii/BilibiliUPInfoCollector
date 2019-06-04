using System;

namespace BilibiliUPInfoCollector.Model
{
    static public class ExtensionMethod
    {
        public static int ToAreaTypeComboBoxIndex(this AreaType type)
        {
            switch (type)
            {
                case AreaType.All: return 0;
                case AreaType.ChangJian: return 1;
                case AreaType.WuJian: return 2;
                case AreaType.VideoChat: return 3;
                case AreaType.Talent: return 4;
                case AreaType.VirtualAnchor: return 5;
                case AreaType.Food: return 6;
                case AreaType.Outdoor: return 7;
                case AreaType.Manual: return 8;
                case AreaType.Pet: return 9;
                case AreaType.Study: return 10;
                case AreaType.VideoComment: return 11;
                case AreaType.Music: return 12;
                case AreaType.LOL: return 1;
                case AreaType.APEX: return 2;
                case AreaType.PUBG: return 3;
                case AreaType.OW: return 4;
                case AreaType.Dota2: return 5;
                case AreaType.DotaAutoChess: return 6;
                case AreaType.Lushi: return 7;
                case AreaType.DNF: return 8;
                case AreaType.CSGO: return 9;
                case AreaType.WOW: return 10;
                case AreaType.WZRY: return 1;
                case AreaType.CJZC: return 2;
                case AreaType.ConsoleGame: return 1;
                case AreaType.Minecraft: return 2;
                default: throw new FormatException("无匹配项");
            }
        }        

    }
}
