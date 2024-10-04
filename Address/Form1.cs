using MySql.Data.MySqlClient;

namespace Address
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string connection = "server=127.0.0.1;userid=root;password=root;database=address";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    if (txbDestinatario.Text != null)
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO `information` (`Destinatario`,`TipoLog`, `NomeLog`, `Number`, `Complemento`, `Bairro`, `CEP`, `Cidade`, `Estado`) VALUES (@Destinatario, @TipoLog, @NomeLog, @Number, @Complemento, @Bairro, @CEP, @Cidade, @Estado);", conn);
                        cmd.Parameters.AddWithValue("@Destinatario", txbDestinatario.Text);
                        cmd.Parameters.AddWithValue("@TipoLog", txbTipoLog.Text);
                        cmd.Parameters.AddWithValue("@NomeLog", txbNomeLog.Text);
                        cmd.Parameters.AddWithValue("@Number", txbNumero.Text);
                        cmd.Parameters.AddWithValue("@Complemento", txbComplemento.Text);
                        cmd.Parameters.AddWithValue("@Bairro", txbBairro.Text);
                        cmd.Parameters.AddWithValue("@CEP", txbCep.Text);
                        cmd.Parameters.AddWithValue("@Cidade", txbCidade.Text);
                        cmd.Parameters.AddWithValue("@Estado", txbEstado.Text);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    using (SaveFileDialog salvarArquivo = new SaveFileDialog())
                    {
                        salvarArquivo.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
                        salvarArquivo.Title = "Salvar Arquivo";

                        if (salvarArquivo.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(salvarArquivo.FileName, "Destinatario: " + txbDestinatario.Text + "\n" + "Tipo do Logradouro: " + txbTipoLog.Text + "\n" + "Nome do Logradouro: " + txbNomeLog.Text + "\n" + "Número: " + txbNumero.Text + "\n" + "Complemento: " + txbComplemento.Text
                                + "\n" + "Bairro: " + txbBairro.Text + "\n" + "CEP:: " + txbCep.Text + "\n" + "Cidade: " + txbCidade.Text + "\n" + "Estado: " + txbEstado.Text + "\n");

                            MessageBox.Show("Você salvou seu arquivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o registro: " + ex.Message);
                }
                finally
                {
                    txbDestinatario.Text = null;
                    txbTipoLog.Text = null;
                    txbNomeLog.Text = null;
                    txbNumero.Text = null;
                    txbNumero.Text = null;
                    txbComplemento.Text = null;
                    txbBairro.Text = null;
                    txbCep.Text = null;
                    txbCidade.Text = null;
                    txbEstado.Text = null;

                }
            }
        }
    }
}