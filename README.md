# Live Project BlueRibbons
These are files from a MVC code first app that i worked on that takes items that are heavily discounted from amazon and put them all in one place. 

Initially i added a wishlist model and scaffolded a controller and views for the wishlist.

After that i took on a larger project working in the campaignsController to go in the database and check if there were any campaigns expiring soon(within 7 days) using a lambda statement. With that i used a if statement to say if there were not any expiringCampaigns to revert back to the full database of campaigns.
