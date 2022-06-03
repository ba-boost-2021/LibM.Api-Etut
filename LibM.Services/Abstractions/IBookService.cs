using LibM.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Services.Abstractions
{
    public interface IBookService
    {
        bool Add(NewBookDto dto);
    }
}
