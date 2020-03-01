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
        private readonly IHistory _history;
        private readonly IHelpInfo _help;

        public MainPresenter(IMainForm view, IMessageService service, IConverter converter, IHistory history, IHelpInfo help)
        {
            _view = view;
            _messageService = service;
            _converter = converter;
            _history = history;
            _help = help;

            _view.ExecutClick += _view_ExecutClick;
            _view.HistoryClick += _view_HistoryClick;
            _view.HelpClick += _view_HelpClick;
        }

        private void _view_HelpClick(object sender, EventArgs e)
        {
            IInfoForm _info = new InfoForm();
            _info.TextBox = _help.Content;
            _info.NameForm = "Справка";
            _info.ShowForm();
        }

        private void _view_HistoryClick(object sender, EventArgs e)
        {
            IInfoForm _info = new InfoForm();
            _info.TextBox = _history.Content;
            _info.NameForm = "История";
            _info.ShowForm();
        }

        private void _view_ExecutClick(object sender, EventArgs e)
        {
            try
            {
                if (_view.InitialNumber != "0")
                {
                    _view.Result = _converter.ConvertNumber(_view.P1, _view.P2, _view.InitialNumber);
                    _history.WriteToHistory(String.Format("{0}: {1} => {2}: {3}", Convert.ToString(_view.P1), _view.InitialNumber, Convert.ToString(_view.P2), _view.Result));
                }
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
            History history = new History();
            HelpInfo help = new HelpInfo();

            MainPresenter presenter = new MainPresenter(form, service, converter, history, help);

            Application.Run(form);
        }
    }
}
