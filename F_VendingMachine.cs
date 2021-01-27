using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class F_VendingMachine : Form
    {
        Globais globais = new Globais();
        double valorSelecionado = 0;
        double valorinserido = 0;
        string bebidaSelecionada = string.Empty;
        public F_VendingMachine()
        {
            InitializeComponent();
        }

        private void btn_verEstoque_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(@"
            Coca Cola: {0}
            Fanta: {1}
            Dolly: {2}",globais.qtdCocacola,globais.qtdFanta,globais.qtdDolly));
        }

        private void btn_vendasTotais_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(@"Valor total de vendas: R${0}", globais.valorTotalVendas));
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (tb_valorInserido.Text == string.Empty)
            {
                MessageBox.Show("Por favor, insira um valor");
                return;
            }
            else
            {
                valorinserido = double.Parse(tb_valorInserido.Text);
                if (rb_coca.Checked)
                {
                    bebidaSelecionada = "cocacola";
                    valorSelecionado = 3.00;
                }
                else if (rb_fanta.Checked)
                {
                    bebidaSelecionada = "fanta";
                    valorSelecionado = 2.50;
                }
                else if (rb_dolly.Checked)
                {
                    bebidaSelecionada = "dolly";
                    valorSelecionado = 2.00;
                }
                if (valorinserido < valorSelecionado)
                {
                    MessageBox.Show("Valor inserido imcompleto para a compra\nFaltam: R$" + (valorSelecionado - valorinserido));
                    return;
                }
                else if (valorinserido > valorSelecionado)
                {
                    if (rb_coca.Checked)
                    {
                        if (bebidaSelecionada == "cocacola" && globais.qtdCocacola < 1)
                        {
                            MessageBox.Show("Não há mais Coca-Cola em estoque para venda");
                        }
                        else
                        {
                            MessageBox.Show("Compra realizada com sucesso\nSeu troco é de: R$" + (valorinserido - valorSelecionado));
                            globais.qtdCocacola--;
                            globais.qtdVendas++;
                            globais.valorTotalVendas += valorSelecionado;
                        }
                    }

                    if (rb_fanta.Checked)
                    {
                        if (bebidaSelecionada == "fanta" && globais.qtdFanta < 1)
                        {
                            MessageBox.Show("Não há mais Fanta em estoque para venda");
                        }
                        else
                        {
                            MessageBox.Show("Compra realizada com sucesso\nSeu troco é de: R$" + (valorinserido - valorSelecionado));
                            globais.qtdFanta--;
                            globais.qtdVendas++;
                            globais.valorTotalVendas += valorSelecionado;
                        }
                    }

                    if (rb_dolly.Checked)
                    {
                        if (bebidaSelecionada == "dolly" && globais.qtdDolly < 1)
                        {
                            MessageBox.Show("Não há mais Dolly em estoque para venda");
                        }
                        else
                        {
                            MessageBox.Show("Compra realizada com sucesso\nSeu troco é de: R$" + (valorinserido - valorSelecionado));
                            globais.qtdDolly--;
                            globais.qtdVendas++;
                            globais.valorTotalVendas += valorSelecionado;
                        }
                    }
                }
                else
                {
                    if (rb_coca.Checked)
                    {
                        if (bebidaSelecionada == "cocacola" && globais.qtdCocacola < 1)
                        {
                            MessageBox.Show("Não há mais Coca-Cola em estoque para venda");
                        }
                        else
                        {
                            MessageBox.Show("Compra realizada com sucesso\nSeu troco é de: R$" + (valorinserido - valorSelecionado));
                            globais.qtdCocacola--;
                            globais.qtdVendas++;
                            globais.valorTotalVendas += valorSelecionado;
                        }
                    }

                    if (rb_fanta.Checked)
                    {
                        if (bebidaSelecionada == "fanta" && globais.qtdFanta < 1)
                        {
                            MessageBox.Show("Não há mais Fanta em estoque para venda");
                        }
                        else
                        {
                            MessageBox.Show("Compra realizada com sucesso\nSeu troco é de: R$" + (valorinserido - valorSelecionado));
                            globais.qtdFanta--;
                            globais.qtdVendas++;
                            globais.valorTotalVendas += valorSelecionado;
                        }
                    }

                    if (rb_dolly.Checked)
                    {
                        if (bebidaSelecionada == "dolly" && globais.qtdDolly < 1)
                        {
                            MessageBox.Show("Não há mais Dolly em estoque para venda");
                        }
                        else
                        {
                            MessageBox.Show("Compra realizada com sucesso\nSeu troco é de: R$" + (valorinserido - valorSelecionado));
                            globais.qtdDolly--;
                            globais.qtdVendas++;
                            globais.valorTotalVendas += valorSelecionado;
                        }
                    }
                }
                tb_valorInserido.Clear();
                tb_valorInserido.Focus();
            }
        }

        private void tb_valorInserido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                if (tb_valorInserido.Text.Contains(","))
                {
                    e.Handled = true; 
                }
            }

            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quantidade de vendas: " + globais.qtdVendas);
        }
    }
}
