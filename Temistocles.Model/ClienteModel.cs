﻿using Temistocles.Entity;
using Temistocles.DAO;
using System.Collections.Generic;
using System;

namespace Temistocles.Model {
    public class ClienteModel {
        public static ClienteEntity CadastrarCliente(ClienteEntity cliente) {
            return new Banco().CadastrarCliente(cliente);
        }

        public static List<ClienteEntity> ListarCliente() {
            return new Banco().ListarCliente();
        }

        public static List<ClienteEntity> SelecionarCliente(int id) {
            return new Banco().SelecionarCliente(id);
        }

        public static ClienteEntity EditarCliente(ClienteEntity cliente) {
            return new Banco().EditarCliente(cliente);
        }

        public static AvaliacaoEntity CriarAvaliacao(AvaliacaoEntity avaliacao) {
            return new Banco().CriarAvaliacao(avaliacao);
        }
    }
}
