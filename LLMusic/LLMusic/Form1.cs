using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLMusic
{
    public partial class FormLLMusic : Form
    {
        public FormLLMusic()
        {
            InitializeComponent();
            BtnPause.Enabled = false;
            BtnContinua.Enabled = false;
            BtnDeleta.Enabled = false;
            BtnDeleta2.Enabled = false;
            BtnPlaySelec.Enabled = false;
            BtnStop.Enabled = false;
            BtnAleatório.Enabled = false;
            BtnProximo.Enabled = false;
            BtnDeletaQlq.Enabled = false;
        }
        string a;
        No Temporario = new No();
        Lista lista = new Lista();
        Lista lista2 = new Lista();

        int musicatoc;

        private NAudio.Wave.BlockAlignReductionStream stream = null;
        private NAudio.Wave.DirectSoundOut output = null;

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            try
            {   //Abre arquivo
                OpenArq = new FolderBrowserDialog();
                OpenArq.ShowDialog();
                // pega o caminho deles e verifica se é mp3
                string Open = OpenArq.SelectedPath;
                
                string[] Arquivo = Directory.GetFiles(Open, "*.mp3");

         
                foreach (string i in Arquivo)
                {
                    //  insere o caminho na lista
                    //a = Path.GetFileName(i);
                    lista.Insere(i);
                }

                Temporario = lista._cabeca;
                // Verifica se o temporario tem algum arquivo mp3, se não tiver ele pede pra colocar outro válido.
                if (Temporario == null)
                {
                    MessageBox.Show("Coloca um arquivo válido com mp3 amigão", "Arquivo Inválido");
                    return;
                }
                else// se tiver certo os caminhos dentro do temporario, ele habilita os botões.
                {
                    MostrarTREE();
                    BtnDeleta.Enabled = true;
                    BtnDeleta2.Enabled = true;
              
                    BtnPlaySelec.Enabled = true;
                    BtnAleatório.Enabled = true;
                    BtnProximo.Enabled = true;
                    BtnDeletaQlq.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Deu boa não tenta denovo");
            }
        }

        private void BtnPlaySelec_Click(object sender, EventArgs e)
        {   // Chama método
            PlayMusicaSelected();
        }
        private void BtnPause_Click(object sender, EventArgs e)
        {   // Verifica se tem alguma música tocando, se tiver ele pausa.       
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Pause();
            }
            BtnContinua.Enabled = true;
            BtnPause.Enabled = false;
        }

        private void BtnContinua_Click(object sender, EventArgs e)
        { // Verifica se tem alguma música pausada, se tiver ele da play
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();
            }
            // Ativa e desativa os botões
            BtnPause.Enabled = true;
            BtnContinua.Enabled = false;
        }
        private void BtnDeleta_Click(object sender, EventArgs e)
        {   //Chama Método
            RetiraInicio();
        }
        private void BtnDeleta2_Click(object sender, EventArgs e)
        {   //Chama Método
            DeletaMusica2();
        }
        private void BtnDeletaQlq_Click(object sender, EventArgs e)
        {   //Chama Método
            Deleta();
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {   // Apenas para a música que está tocando. não dá pra voltar de onde parou (ele fecha a thread)
            output.Stop();           
            BtnPlaySelec.Enabled = true;
            BtnPause.Enabled = false;
            BtnContinua.Enabled = false;
            BtnStop.Enabled = false;
            BtnAleatório.Enabled = true;
            BtnProximo.Enabled = true;          
        }
        private void BtnAleatório_Click(object sender, EventArgs e)
        {   //Chama Método
            Aleatorio();
        }
        private void BtnProximo_Click(object sender, EventArgs e)
        {   //Chama Método
            ProximaMusica();
        }

        private void MostrarTREE()
        {
                TreeMostra.Nodes.Clear();
                // atribuindo valor pra entrar no while
                Temporario = lista._cabeca;

                while (Temporario != null)
                {
                    AudioFileReader teste = new AudioFileReader(Temporario.Valor);

                //insere o caminho que está guardado na variavel do tipo nó.
                    TreeMostra.Nodes.Add(Temporario.Valor.ToString());
                    //TreeMostra.Nodes.Add(Temporario.Valor.ToString());
                    //tempo de duração da musica  
                    TreeMostra.Nodes[TreeMostra.Nodes.Count-1].Nodes.Add("Duração: " + teste.TotalTime.ToString());
                    // aqui ele pega o próximo valor pra mostrar denovo na proxima vez que rodar o while até ele não ter
                    //mais valor para mostrar
                    Temporario = Temporario.Proximo;
                }
                // Se não tiver nada na lista cabeça eu não consigo passar o valor para a temporaria, então ele  pede
                //para importar denovo e bloqueia todos os botôes
            if (lista._cabeca == null)
            {
                MessageBox.Show("Você deletou todos os itens da lista, importe o arquivo denovo");
                BtnPause.Enabled = false;
                BtnContinua.Enabled = false;
                BtnDeleta.Enabled = false;
                BtnDeleta2.Enabled = false;
                BtnPlaySelec.Enabled = false;
                BtnStop.Enabled = false;
                BtnAleatório.Enabled = false;
                BtnProximo.Enabled = false;
                BtnDeletaQlq.Enabled = false;
                return;
            }

        }
        private void RetiraInicio()
        {    // verifica se tem música tocando, para pausar ela e depois retirar
            if (output != null)
            {
                output.Stop();
            }
            BtnPlaySelec.Enabled = true;
            BtnPause.Enabled = false;
            BtnContinua.Enabled = false;
            BtnStop.Enabled = false;
            // chama o metodo da lista que retira o primeiro elemento.
            lista.retiraInicio();
            // Atualiza meu tree chamando o metodo que printa os valores da minha variavel temporaria.
            MostrarTREE();
        }

        private void DeletaMusica2()
        {
            if (lista._cabeca == null)
                return;
            if (output != null)
            {
                output.Stop();
            }
            BtnPlaySelec.Enabled = true;
            BtnPause.Enabled = false;
            BtnContinua.Enabled = false;
            BtnStop.Enabled = false;
            // chama o metodo da lista que retira o ultimo elemento.
            lista.retiraFim();
            MostrarTREE();
            
        }
        private void Deleta()
        {
            try
            {
                if (lista._cabeca == null)
                    return;
                if (output != null)
                {
                    output.Stop();
                }
                BtnPlaySelec.Enabled = true;
                BtnPause.Enabled = false;
                BtnContinua.Enabled = false;
                BtnStop.Enabled = false;
                // Retira o elemento que está  selecionado no tree e retira ele da lista.
                lista.retiraSelecionado(TreeMostra.SelectedNode.Index);
                MostrarTREE();
            }
            catch
            {
                MessageBox.Show("Seleciona a música que você quer apagar!");
            }
        }


        private void PlayMusicaSelected()
        {
            try
            {// ve a musica selecionada e pega o index dela que automaticamente é a posiçao dela na lista e toca ela.
                NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(TreeMostra.SelectedNode.Text));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
                output = new NAudio.Wave.DirectSoundOut();
                output.Init(stream);
                output.Play();
                BtnPause.Enabled = true;
                BtnPlaySelec.Enabled = false;
                BtnStop.Enabled = true;
                BtnAleatório.Enabled = true;
                BtnProximo.Enabled = true;
                musicatoc = TreeMostra.SelectedNode.Index;
            }
            catch
            {
                MessageBox.Show("Não tem nenhuma música selecionada");
            }
        }
        private void Aleatorio()
        {
           
            int i = 0;
            for (i = 0; i < TreeMostra.Nodes.Count; i++)
            {
                //Só pra contar quantos nodes tem para pegar o index dele e fazer o aleatorio
            }         
            Random rdn = new Random();
            int strNumeroaleatorio;
            strNumeroaleatorio = rdn.Next(0, i - 1);// gera  o numero aleatorio de 0 até o tamanho do treeview
        
            if (output != null)
            {
                output.Stop();
            }
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(TreeMostra.Nodes[strNumeroaleatorio].Text));//TreeMostra.SelectedNode.Text
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();
            BtnPause.Enabled = true;
            BtnPlaySelec.Enabled = false;
            BtnStop.Enabled = true;
            BtnProximo.Enabled = true;
        }

       private void ProximaMusica()
        { 
            try
            {
                if (output != null)
                {
                    output.Stop();
                }
                if (musicatoc == TreeMostra.Nodes.Count -1 )
                {
                    musicatoc = 0;
                }
                else
                {
                    musicatoc++;
                }
                NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(TreeMostra.Nodes[musicatoc].Text));//TreeMostra.SelectedNode.Text
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
                output = new NAudio.Wave.DirectSoundOut();
                output.Init(stream);
                output.Play();
                BtnPause.Enabled = true;
                BtnPlaySelec.Enabled = false;
                BtnStop.Enabled = true;
                BtnProximo.Enabled = true;
            }
            catch 
            {
                MessageBox.Show("Você tem que selecionar uma música primeiro para depois tocar a proxima ");
            }
        }
    }
}
