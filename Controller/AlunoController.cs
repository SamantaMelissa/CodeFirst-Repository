using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alunos.EfCore.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alunos.EfCore.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoRepository _alunoRepository;




    }
}
