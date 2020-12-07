# Картонная фабрика

Команда:
  Мухин
  Павлов
  Устинов
  Эверстов

Цели: Автоматизация учета выпущенного товара.

Картонная фабрика занимается выпуском разных картонных изделий (Коробки разного объема, фасона и т.д.). Для автоматизации учета выпущенного товара необходимо разработать программное обеспечение. Фабрика работает по сменам, смена состоит из бригадира и 15 рабочих. После каждой смены бригадир должен сдавать документ с информацией что и сколько они сделали за смену. Информацию должны вносить бригадир и отдел экономического планирования. Отдел экономического планирования планирует объем выпуска на полгода и должна следить за выполнением плана, если план за смену не выполнен они обязаны взять объяснительную с бригадира. Для отчетности отделу планирования нужны следующие виды отчетов:

1. План работ на месяц,
2. Фактическое выполнение плана,
3. Сравнительный анализ выполнения плана.

Список классов:
    1:
        Employee
        Position
        Status
        Shift
        Daily prod
    2:
        Product
        Plan
        Planned
    3:
        ProductRemain
        Storage
        Department
        ProductionLine
    4:
        ProductOperation
        Factory
