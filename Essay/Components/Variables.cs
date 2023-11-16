using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essay.Components
{
    public class Variables
    {
        public static  Color _BackGround = Color.FromArgb(40,40,40);
        public static Color _BtnTitle = Color.FromArgb(100, 250, 250, 250);
        public static Color _HoverENav = Color.FromArgb(255, 76, 86, 97);
        public static Color _BackNav = Color.FromArgb(45, 46, 45);
        public static Color _HoverBtn = Color.FromArgb(76, 86, 97);

        public static Color _Back_Items_User = Color.FromArgb(187,187,187);
        public static Color _Back_Items_Manager = Color.FromArgb(110, 194, 247);

        public static bool _isExpandedNav = true;
        public static int _X_Item_User = 20;
        public static int _X_Label_User = 60;
        public static int _Width_SetCent = 0;

        public static String _rootIMG = "Img";
        public static String _pathAvt = $"{_rootIMG}/Avt";

        public static String _rootFile = "File";
        public static String _pathFileImport = $"{_rootFile}/Import";
        public static String _pathFileExport = $"{_rootFile}/Export";



    }


}
