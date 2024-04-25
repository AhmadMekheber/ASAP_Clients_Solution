using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Clients.Utils.Enums
{
    public enum PolygonRequestType
    {
        [Display(Name = "Previous Close")]
        PreviousClose = 1
    }
}