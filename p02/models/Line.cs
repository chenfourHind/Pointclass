using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.models {
    class Line {
        private Point2D a;
        private Point2D b;

        public Line() {
        
        }

        public Line(Point2D a, Point2D b) {
            this.a = a;
            this.b = b;
        }

        public void SetA(Point2D a) {
            this.a = a;
        }

        public Point2D GetA() {
            return a;
        }

        public void SetB(Point2D b) {
            this.b = b;
        }

        public Point2D GetB(){
            return b;
        }
    }
}
