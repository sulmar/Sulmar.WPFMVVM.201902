using OLSA.Breakdowns.IServices;
using OLSA.Breakdowns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OLSA.Breakdowns.ViewModels
{
    public class AddBreakdownViewModel : EntitiesViewModel<Workplace>
    {
        public Breakdown Breakdown { get; set; }

        public ICommand SendCommand { get; }

        private readonly IBreakdownService breakdownService;

        public AddBreakdownViewModel(
            IWorkplaceService entityService, 
            IBreakdownService breakdownService)
            : base(entityService)
        {
            this.breakdownService = breakdownService;

            SendCommand = new RelayCommand(Send, () => CanSend);

            Breakdown = new Breakdown();         
        }

       
        public void Send()
        {
            breakdownService.Add(Breakdown);

        }

        public bool IsWorkplaceSelected => SelectedEntity != null;

        public bool CanSend => IsWorkplaceSelected && 
            !string.IsNullOrEmpty(Breakdown.Description);

    }
}
