using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    internal class Spaceship
    {
        public Spaceship(vec3 pos, int cargoSize, int maxCargoSize, int snelheid, int ammo)
        {
            Positie = pos;
            CargoSize = cargoSize;
            MaxCargoSize = maxCargoSize;
            Snelheid = snelheid;
            Ammo = ammo;
        }

        public vec3 getPositie() { return Positie; }
        public void setPositie(int x, int y, int z)
        {
            Positie.x = x;
            Positie.y = y;
            Positie.z = z;
        }

        public int getCargoSize() { return CargoSize; }
        public void setCargoSize(int CargoSize) { this.CargoSize = CargoSize; }

        public int getMaxCargoSize() { return MaxCargoSize; }
        public void setMaxCargoSize(int MaxCargoSize) { this.MaxCargoSize = MaxCargoSize; }

        public int getSnelheid() { return Snelheid; }
        public void setSnelheid(int Snelheid) { this.Snelheid = Snelheid; }

        public int getAmmo() { return Ammo; }
        public void setAmmo(int Ammo) { this.Ammo = Ammo; }
        
        public void move(vec3 change) 
        { 
            Positie.x += change.x; 
            Positie.y += change.y; 
            Positie.z += change.z; 
        }

        public void LoadCargo(int gewicht)
        {
            if ((CargoSize + gewicht) <= MaxCargoSize) CargoSize += gewicht;
        }

        public void Schoot() { Ammo--; }

        private vec3 Positie = new vec3(0, 0, 0);
        private int CargoSize;
        private int MaxCargoSize;
        private int Snelheid;
        private int Ammo;
    }
}
