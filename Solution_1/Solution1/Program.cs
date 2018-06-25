using System;


namespace Solution1
{
    class Program
    {
        static int CreateVector(int ax, int ay, int bx, int by)
        //ax,ay - координаты a
        // bx,by - координаты b 
        {
            return ax * by - bx * ay;
        }
        static bool Check(int a)
        {
            return a < 0;   
        }
static bool LinesCross(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)//пересекаются ли отрезки?
        {
            int v1 = CreateVector(x4 - x3, y4 - y3, x1 - x3, y1 - y3);
            int v2 = CreateVector(x4 - x3, y4 - y3, x2 - x3, y2 - y3);
            int v3 = CreateVector(x2 - x1, y2 - y1, x3 - x1, y3 - y1);
            int v4 = CreateVector(x2 - x1, y2 - y1, x4 - x1, y4 - y1);
            if (Check(v1 * v2) && Check(v3 * v4)) // v1v2 < 0  и v3v4<0, отрезки пересекаются
                return true;
            else return false;
        }

        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.Read());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.Read());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.Read());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.Read());
            int y4 = Convert.ToInt32(Console.ReadLine());
            if (LinesCross(x1, y1, x2, y2, x3, y3, x4, y4))
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
            }

    }

    }
Program geometr4;
{Пересекаются ли 2 отрезка?}
Const _Eps: Real=1e-9; {точность вычслений}
var x1, y1, x2, y2, x3, y3, x4, y4: integer;
var v1, v2, v3, v4: integer;
function RealLess(Const a, b: integer): Boolean; {Строго меньше}
begin
  RealLess := b-a> _Eps
end; {RealLess}
function VektorMulti(ax, ay, bx, by:integer): integer;
{ax,ay - координаты a
 bx,by - координаты b }
begin
  vektormulti:= ax* by-bx* ay;
end;
Function LinesCross(x1, y1, x2, y2, x3, y3, x4, y4:integer): boolean;
{Пересекаются ли отрезки?}
begin
  v1:=vektormulti(x4-x3, y4-y3, x1-x3, y1-y3);
v2:=vektormulti(x4-x3, y4-y3, x2-x3, y2-y3);
v3:=vektormulti(x2-x1, y2-y1, x3-x1, y3-y1);
v4:=vektormulti(x2-x1, y2-y1, x4-x1, y4-y1);
  if RealLess(v1* v2,0) and RealLess(v3* v4,0)
{ v1v2 < 0  и v3v4<0, отрезки пересекаются}
then LinesCross:= true
    else LinesCross:= false
end; {LinesCross}
begin {main}
  Read(x1);
Readln(y1);
Read(x2);
Readln(y2);
Read(x3);
Readln(y3);
Read(x4);
Readln(y4);
  if LinesCross(x1, y1, x2, y2, x3, y3, x4, y4)
    then writeln('Yes')
    else writeln('No')


end.
