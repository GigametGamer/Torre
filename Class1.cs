using System;
using System.Collections.Generic;
using System.Text;

namespace Torre
{
    using System;
    using System.Runtime.InteropServices;

    class Class1
    {
        // --- IMPORTAÇÕES DA API DO WINDOWS ---
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern bool SetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool bMaximumWindow, ref CONSOLE_FONT_INFO_EX lpConsoleCurrentFontEx);

        // Nova importação necessária para a tela cheia
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetConsoleDisplayMode(IntPtr hConsoleOutput, uint dwFlags, out COORD lpNewScreenBufferDimensions);

        private const int STD_OUTPUT_HANDLE = -11;

        // Estruturas necessárias
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct CONSOLE_FONT_INFO_EX
        {
            public uint cbSize;
            public uint nFont;
            public short dwFontSizeX;
            public short dwFontSizeY;
            public int FontFamily;
            public int FontWeight;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string FaceName;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct COORD
        {
            public short X;
            public short Y;
        }

        // --- SUA FUNÇÃO DE ZOOM ---
        public static void DefinirTamanhoFonteConsole(short tamanho)
        {
            IntPtr hnd = GetStdHandle(STD_OUTPUT_HANDLE);
            if (hnd != IntPtr.Zero)
            {
                CONSOLE_FONT_INFO_EX info = new CONSOLE_FONT_INFO_EX();
                info.cbSize = (uint)Marshal.SizeOf(info);
                info.dwFontSizeY = tamanho;
                info.FaceName = "Consolas";

                SetCurrentConsoleFontEx(hnd, false, ref info);
            }
        }

        // --- NOVA FUNÇÃO PARA TELA CHEIA ---
        public static void AtivarTelaCheia()
        {
            IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
            if (hConsole != IntPtr.Zero)
            {
                // O número 1 força o modo Full Screen no CMD
                SetConsoleDisplayMode(hConsole, 1, out COORD novaDimensao);
            }
        }
    }


}
