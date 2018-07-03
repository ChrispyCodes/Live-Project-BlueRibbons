using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueRibbonsReview.Models
{
    public class Wishlist
    {
        public int WishlistId { get; set; }
        public int CampaignId { get; set; }
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}