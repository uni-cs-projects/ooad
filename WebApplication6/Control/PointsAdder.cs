using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Entity;

namespace WebApplication6.Control
{
    public class PointsAdder
    {
        public void addPoints(int mid,int pid,int run,int wic,int six,int four){
            Points a = new Points() { matchid = mid, playerid = pid, runs = run, wickets = wic, sixes = six, fours = four };
            a.add();
        }
    }
}