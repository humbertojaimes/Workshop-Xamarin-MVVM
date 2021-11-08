using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkshopXamarinFormsApi.DataContext;
using XamarinWorkshop.DTO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace XamarinWorkshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchesController : ControllerBase
    {

        private readonly BranchesContext branchesContext;

        public BranchesController(BranchesContext branchesContext)
        {
            this.branchesContext = branchesContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PaginationFilter filter)
        {
            PaginationFilter processedFilter = new(1, 30);
            if (filter is not null)
                processedFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);

            var pagedData = branchesContext.Branches.ToList()
               .Skip((processedFilter.PageNumber - 1) * processedFilter.PageSize)
               .Take(processedFilter.PageSize)
               .ToList();

            return Ok(pagedData);
        }

        [HttpPost]
        public async Task<IActionResult> Post(NewBranch branch)
        {

            WorkshopXamarinFormsApi.DataContext.Branch newBranch = new()
            {
                Name = branch.Name,
                Location = branch.Address,
            };

            await branchesContext.Branches.AddAsync(newBranch);

            return Ok();

        }

    }
}
