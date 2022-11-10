using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.models {
    class Point3D {
        private double x;
        private double y;

        public Point3D() {

        }

        public Point3D(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public void SetX(double x) {
            this.x = x;
        }

        public double GetX() {
            return x;
        }

        public void SetY(double y) {
            this.y = y;
        }

        public double GetY() {
            return y;
        }

    }
}
