using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.models {
    class Point2D {
        private double x;
        private double y;

        public Point2D() {

        }

        public Point2D(double x, double y) {
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

        public double GetDistance(Point2D p) {
            double d = 0, a;

            a = (p.x * p.x) + (p.y * p.y);
            d = Math.Sqrt(a);

            return d;
        }

        public bool IsEqual(Point2D p){
            if (p.x == this.x && p.y == this.y) {
                return true;
            }
            return false;
        }

        public void Translate(double xd, double yd) {
            x += xd;
            y += yd;
        }

        public bool IsLinear(Point2D p1, Point2D p2) {
            double coef1, coef2;

            coef1 = (this.y - p1.y) / (this.x - p1.x);
            coef2 = (p2.y - p1.y) / (p2.x - p1.x);

            if (coef1 == coef2) {
                return true;
            }
            return false;
        }
    }
}
