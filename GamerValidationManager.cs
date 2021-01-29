using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerValidationManager : IGamerValidationService
    {
        
        bool IGamerValidationService.Validate(Gamer gamer)
        {
            if (gamer.GamerName=="TUGAY" && gamer.SureName=="SENGUL" && gamer.GamerBirthYear=="1993" && gamer.GamerId==1 && gamer.GamerIdentityNo=="12345")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
