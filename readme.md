# Clipboard History

Clipboard History - это приложение для Windows Forms, которое отслеживает изменения в буфере обмена и сохраняет их историю.

## Функциональные возможности

- Отслеживание изменений в буфере обмена
- Сохранение истории буфера обмена
- Логирование событий
- Отображение истории буфера обмена в интерфейсе

## Установка

1. Клонируйте репозиторий:
    
```
    git clone https://github.com/tim-ushakow/clipboard-history-app.git
    
```
2. Откройте проект в Visual Studio 2022.
3. Постройте проект, чтобы установить все необходимые зависимости.

## Использование

1. Запустите приложение.
2. Приложение начнет отслеживать изменения в буфере обмена.
3. История буфера обмена будет отображаться в интерфейсе приложения.

## Структура проекта

- `MainForm.cs`: Основная форма приложения, содержит интерфейс и логику взаимодействия с пользователем.
- `ClipboardApplication.cs`: Основной класс приложения, содержит логику работы с буфером обмена и логированием.
- `ClipboardMonitor.cs`: Класс для отслеживания изменений в буфере обмена.
- `ClipboardList.cs`: Класс для хранения истории буфера обмена.
- `Logger.cs`: Класс для логирования событий.

## Пример кода


```
public class ClipboardList
{
    public List<ClipboardData> list;

    public ClipboardList()
    {
        list = new List<ClipboardData>();
    }

    public void Add(string data)
    {
        list.Add(new ClipboardData(data));
    }
}

```

## Требования

- Visual Studio 2022
- .NET 8

## Лицензия

Этот проект лицензирован под MIT License. Подробности см. в файле [LICENSE](LICENSE).

## Авторы

- [Timofey Ushakov](https://github.com/tim-ushakow)

## Contirbutors

- [Denis Abrosimov](https://github.com/abrosimov-d)
