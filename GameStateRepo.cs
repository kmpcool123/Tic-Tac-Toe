using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{

    public class GameStateRepo : GameUI

    {
        public static int CheckWin()
        
        {

            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }

            else if (arr[4] == arr[5] && arr[5] == arr[6])

                {

                    return 1;

                }

                   

                else if (arr[6] == arr[7] && arr[7] == arr[8])

                {

                    return 1;

                }

                       

                else if (arr[1] == arr[4] && arr[4] == arr[7])

                {

                    return 1;

                }

                 

                else if (arr[2] == arr[5] && arr[5] == arr[8])

                {

                    return 1;

                }

                

                else if (arr[3] == arr[6] && arr[6] == arr[9])

                {

                    return 1;

                }

                

                else if (arr[1] == arr[5] && arr[5] == arr[9])

                {

                    return 1;

                }

                else if (arr[3] == arr[5] && arr[5] == arr[7])

                {

                    return 1;

                }

               

                // draw 

                else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')

                {

                    return -1;

                }

              



                else

                {

                    return 0;

                }
        }
    }  

}
