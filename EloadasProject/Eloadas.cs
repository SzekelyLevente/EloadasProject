using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloadasProject
{
    public class Eloadas
    {
        private bool[,] foglalasok;

        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if(sorokSzama>0&&helyekSzama>0)
            {
                foglalasok = new bool[sorokSzama, helyekSzama];
                for (int i = 0; i < sorokSzama; i++)
                {
                    for (int j = 0; j < helyekSzama; j++)
                    {
                        foglalasok[i, j] = false;
                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public int SzabadHelyek()
        {
            int db = 0;
            for (int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    if(!foglalasok[i,j])
                    {
                        db++;
                    }
                }
            }
            return db;
        }

        public bool Foglalas()
        {
            bool l = false;
            int i = 0;
            int j = 0;
            while((i<foglalasok.GetLength(0))&&(!l))
            {
                while((j<foglalasok.GetLength(1))&&(!l))
                {
                    if(!foglalasok[i,j])
                    {
                        foglalasok[i, j] = true;
                        l = true;
                    }
                    j++;
                }
                i++;
            }
            return l;
        }

        public bool Teli()
        {
            return SzabadHelyek() == 0;
        }

        public bool Foglalt(int sorSzam, int helySzam)
        {
            if(sorSzam>0&&helySzam>0)
            {
                if(foglalasok[sorSzam-1,helySzam-1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
