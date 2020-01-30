# AspNetIdentityLaunchPoint
Стартовый проект для создания приложения с использованием AspNet Identity.

Проект включает переопределенные стандартные классы Identity (User, Role, UserRole, UserClaim, UserLogin) с первичным ключом заданным в int. Используется Code-First.

### Дальнейшие шаги

1. Выполнить команду Update-Database в NuGet Package Manager Console для обновления состояния БД до текущей версии.
2. Добавлять сущности и обновлять БД через NuGet Package Manager Console.


### При клонировании возможны две ошибки:

1. Не удается найти компилятор "bin\roslyn\csc.exe" -> читать документ "Возможные ошибки при клонировании.docx"
2. Не удается найти пакеты NuGet (поскольку они не были загружены в git) -> Выполнить восстановление пакетов NuGet через "Управление пакетами NuGet"

![NuGet](https://docs.microsoft.com/ru-ru/nuget/consume-packages/media/managepackagesuicommand.png)

Сверху в окне должна появиться кнопка "Восстановить"
