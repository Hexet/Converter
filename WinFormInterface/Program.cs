using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WinFormInterface
{
    public class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IMessageService _messageService;
        private readonly IConverter _converter;

        public MainPresenter(IMainForm view, IMessageService service, IConverter converter)
        {
            _view = view;
            _messageService = service;
            _converter = converter;

            _view.ExecutClick += _view_ExecutClick;
        }

        private void _view_ExecutClick(object sender, EventArgs e)
        {
            try
            {
                _view.Result = _converter.Transform(_view.P1, _view.P2, _view.InitialNumber);
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            MessageService service = new MessageService();
            Converter converter = new Converter();

            MainPresenter presenter = new MainPresenter(form, service, converter);

            Application.Run(form);
        }
    }
}
