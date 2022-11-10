using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.models {
    class Circle {
        private Point2D center;
        private double r;

        public Circle() {
        
        }

        public Circle(Point2D p, double r) {
            center = p;
            this.r = r;
        }

        public void SetCenter(Point2D p) {
            center = p;
        }

        public Point2D GetCenter() {
            return center;
        }

        public void SetR(double r) {
            this.r = r;
        }

        public double GetR(){
            return r;
        }

    }
}
