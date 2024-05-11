using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DTOs;

namespace Toomeet_Pos.BLL.Interfaces
{
    public interface IMailService
    {
        void SendMailInviteStaff(InviteStaffMailDto dto);
    }
}
