using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary
{
    internal class Catch
    {
        //Properties
        public DateTime CatchTime { get; set; }
        public string Lure { get; set; }
        public string Technique { get; set; }
        public Fish Fish { get; set; }


        //Constructor
        public Catch(Fish caughtFish, DateTime catchTime, string lure, string technique)
        {
            Fish = caughtFish;
            CatchTime = catchTime;
            Lure = lure;
            Technique = technique;
        }



        //CRUD Methods
        public void CreateCatch()
        {
            // Logic to create a new catch
        }
        public void ReadCatch()
        {
            // Logic to read a catch
        }
        public void UpdateCatch()
        {
            // Logic to update a catch
        }
        public void DeleteCatch()
        {
            // Logic to delete a catch
        }
    }
}
