
using odonto_facisa.models;
using odonto_facisa.dao;
using odonto_facisa.dao.impl;
using odonto_facisa.controller;

int opcao = 0;
const char NAO = 'N';

do
{
    opcao = Controller.ShowMenuPrincipal();

    Controller.SelectAction(opcao);

} while (Controller.modalWannaGoOut().Equals(NAO));




