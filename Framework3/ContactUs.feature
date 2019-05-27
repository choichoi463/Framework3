Feature: ContactUs page loading
	In order to contact us 
	As a website user
	I want to be able to navigate to ContactUs page

@sanity
Scenario: Open ContactUs page
	Given I am on start page of blog.io
	When I click on Contact Us menu item
	Then User is redirected to ContactUs page
