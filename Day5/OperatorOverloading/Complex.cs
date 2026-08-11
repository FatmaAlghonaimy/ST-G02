using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.OperatorOverloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }

        //binary operator
        public static Complex operator +(Complex left, Complex right)
        {
            //Complex result = new Complex { 
            //    Real = left.Real+ right.Real,
            //    Imag = left.Imag+ right.Imag
            //};
            //return result ;

            return new Complex
            {
                //precedence operators
                //proiority + higher ??
                Real = (left?.Real ?? 0) +(right?.Real ?? 0),// 2  //4   
                Imag = (left?.Imag ?? 0) + (right?.Imag?? 0  )// 
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            right = new Complex
            {
                Real = -right?.Real ?? 0,
                Imag = -right?.Imag ?? 0
            };
            return left + right;
           
        }


        public static Complex operator ++(Complex c)
        {
            return new Complex
            {
                Real = (c?.Real??0) + 1,
                Imag = c?.Imag??0
            };
        }
        public static Complex operator --(Complex c)
        {
            return new Complex
            {
                Real = (c?.Real??0) - 1,
                Imag = c?.Imag??0
            };
        }

        public static bool operator >(Complex left, Complex right)
        {
            //left.real > right .real -- true 

            //left .real = right.real 
            //left .img > rigth.img -- true

            if (left?.Real == right?.Real)
            {
                return left?.Imag > right?.Imag; //true
            }
            else
            {
                return left?.Real > right?.Real;
            }
        }
        public static bool operator <=(Complex left, Complex right)
        {
            return !(left > right);
            //return left < right || left == right;
        }
        public static bool operator >=(Complex left, Complex right)
        {
            return !(left < right);
        }

        //override equals get hashcode
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Complex left, Complex right)
        {
            return left?.Real == right?.Real && left?.Imag == right?.Imag;
        }
        public static bool operator !=(Complex left, Complex right)
        {
            return !(left == right);
        }
        public static bool operator <(Complex left, Complex right)
        {

            if (left?.Real == right?.Real)
            {
                return left?.Imag < right?.Imag; //true
            }
            else
            {
                return left?.Real < right?.Real;
            }
        }


        public static explicit operator int(Complex c)
        {
            return c?.Real ?? 0;
        }

        public static implicit operator string(Complex c)
        {
            return c?.ToString() ?? string.Empty;
        }
    }
}
