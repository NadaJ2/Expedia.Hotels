Expedia.Hotel application built based on .Net core 2.0 (C#), using MVC framework.

Duirng my work on this application I intended to implement MVC architecture pattern which helps in separation of concern by having
Model to manage the Request (Search Critirea) and Response (returned result from Json Service, transformed into strongly typed object)
Controller(Hotel), Views and Services, in this way I can keep my code clean more readable and maintainable.
also to keep my services loosely coupled and help in testing during my work I used Depenedency injection.
