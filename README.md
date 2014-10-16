Test Dot Net Web App
====================

There are no specific requirements on what modules/libraries you use. Use what you feel comfortable with. I am more concerned 
with how you use the design patterns to get the work done. If any requirement is unclear, please proceed with what you believe 
should be best possible solution. There are no right and wrong answers :)

Excercise:

* An incomplete repository class has been provided. Using an IoC provider, implement an IRepository pattern 
(your choice of container)
* If you want to hook up a database, please go ahead. Only requirement here is that you use EntityFramework context. 
I don't need the database.
* Complete the (Product) and (Category) domain entity classes such that a many-to-many relation exists. 
ie, one product can exist under multiple categories, and one category can have multiple products (POCO code-first)
* There will be multi level categories (ie parent > sub-category > sub-sub-category)
* The following urls are required:
    * / : homepage with a list of categories
    * /catalog/{slug} : list of sub categories and products assigned to that category
    * /product/{slug} : product details page
* the UI doesn't need to be flashy, but as long as it looks ok (you can use Bootstrap if you wish)
* all the controllers need to use DI with the repository pattern
* use Bundling and Minification to serve up css and js
* use [_Layout] and partials wherever you can
* if possible, display a mega-menu of categories
* use caching wherever possible (up to you)
