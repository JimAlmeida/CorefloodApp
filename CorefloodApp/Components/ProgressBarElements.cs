using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorefloodApp
{
    public static class ProgressBarElements
    {
        public static readonly MarkupString AddedRockInput = new("<div class=\"progress-bar\" role=\"progressbar\" style=\"width: 25%\" aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\">Added Rock Arguments!</div>");
        public static readonly MarkupString AddedSimInput = new("<div class=\"progress-bar\" role=\"progressbar\" style=\"width: 25%\" aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\">Added Simulation Arguments!</div>");
        public static readonly MarkupString StartedSimulation = new("<div class=\"progress-bar bg-warning\" role=\"progressbar\" style=\"width: 25%\" aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\">Started Simulation!</div>");
        public static readonly MarkupString FinishedSimulation = new("<div class=\"progress-bar bg-success\" role=\"progressbar\" style=\"width: 25%\" aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\">Finished Simulation!</div>");
    }
}
