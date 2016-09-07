namespace VkNet.Exception
{
    using System;
    using HtmlAgilityPack;

    /// <summary>
    /// Исключение, которое выбрасывается при отсутствии авторизации на выполнение запрошенной операции.
    /// </summary>
    [Serializable]
    public class FormNotFoundException : VkApiException
    {
                /// <summary>
        /// Идентификатор капчи
        /// </summary>
        public HtmlDocument Html { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="UserAuthorizationFailException"/>.
        /// </summary>
        public FormNotFoundException(string message, HtmlDocument html) : base(message)
        {
            Html = html;
        }
    }
}