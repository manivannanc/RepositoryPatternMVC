Repository Pattern
====================
* Product and Category domain entity classes with many-to-many relation . 
ie, one product can exist under multiple categories, and one category can have multiple products (POCO code-first)
* Multi level categories (ie parent > sub-category > sub-sub-category)
*  urls:
    * / : homepage with a list of categories
    * /catalog/{slug} : list of sub categories and products assigned to that category
    * /product/{slug} : product details page
* all  controllers using DI with the repository pattern
*  Bundling and Minification to serve up css and js

