using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Weapon
    {
        private int _bulletCapacity;
        public int BulletCapacity
        {
            get { return _bulletCapacity; }
            set
            {
                if (value >= 0 && value <= 200)
                    _bulletCapacity = value;
            }
        }
        private int _bulletCount;

        public int BulletCount
        {
            get { return _bulletCount; }

            set
            {
                if (value >= 0 || value <= BulletCapacity)
                    _bulletCount = value;
            }
        }

        public bool FireMode { get; set; } = true; // => AutoMode

        public void Shoot()
        {
            BulletCount--;
            Console.WriteLine($"{BulletCount} mermi qaldi");
        }
        public void Fire()
        {
            if (BulletCount == 0)
            {
                Console.WriteLine("Daraqda mermi yoxdu");
            }
            else if (FireMode)
            {
                BulletCount -= BulletCount;
                Console.WriteLine($"Atish modu Avtomatik -- {BulletCount} mermi qaldi");
            }
            else
            {
                BulletCount--;
                Console.WriteLine($"Atish modu Tekli -- {BulletCount} mermi qaldi");
            }
        }
        public void GetRemainBulletCount()
        {
            int needBullet = BulletCapacity - BulletCount;

            Console.WriteLine("Daragin tam dolmagi ucun lazim olan mermi sayi" + " " + needBullet);
        }

        public void Reload()
        {
            if (BulletCount == BulletCapacity)
            {
                Console.WriteLine("Daraq Doludur");
            }
            else
            {
                int result = BulletCapacity - BulletCount;
                BulletCount += result;
                Console.WriteLine($"Daraga {result} edet mermi elave olundu");
            }
        }

        public void ChangeFireMode()
        {
            if (FireMode)
            {
                FireMode = false;
                Console.WriteLine("atish modu tekli oldu");
            }
            else
            {
                FireMode = true;
                Console.WriteLine("atish modu avtomatik oldu ");
            }
        }

        public Weapon(int bulletcapacity, int bulletcount, bool firemode)
        {
            BulletCapacity = bulletcapacity;
            BulletCount = bulletcount;
            FireMode = firemode;
        }

    }
}
