Вариант №7
Создать базовый класс (предметная область) «Домашнее животное» и производные классы «Собака», «Кошка», «Попугай».

В соответствии с индивидуальным заданием на основе базового класса, представляющего собой предметную область, необходимо создать программу для связывания объектов нескольких различных классов в общий массив. Вывести содержимое массива на экран. Общие требования к выполнению задания:
каждый класс должен быть помещен в отдельный файл с именем ИмяКласса;
класс BaseInform, описывающий предметную область, должен иметь не менее пяти свойств, содержащих общую информацию;
базовый класс в иерархии, должен на правах агрегации содержать объект класса BaseInform;
все классы наследники от базового класса, должны иметь дополнительно к базовой информации не менее трех свойств, описывающих объект класса наследника;
массив должен формироваться из объектов не менее чем трех классов, согласно индивидуальному заданию.

Замечание: метод toString() переопределяется во всех классах.

Исходя из того, что восходящие преобразования будут осуществляться автоматически, то создав объекты разных классов AdultChild и UndergradeChild, являющихся наследниками класса Parent, эти созданные объекты можно будет размещать в виде элементов массива.
Реализовать возможность добавления/удаления/редактирования элементов массива.
