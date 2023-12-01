// See https://aka.ms/new-console-template for more information

using C_sharp_APIs.controllers;
using C_sharp_APIs.services;

UserController users= new UserController();

await users.Init();

CommentServices comments= new CommentServices();
comments.GetComments("5");
