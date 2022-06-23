from abc import abstractmethod


class TTriad:
    def __init__(self, number1, number2, number3):
        self.__number1 = number1
        self.__number2 = number2
        self.__number3 = number3

    @property
    def Number1(self):
        return self.__number1

    @Number1.setter
    def Number1(self, number1):
        self.__number1 = number1

    @property
    def Number2(self):
        return self.__number2

    @Number2.setter
    def Number2(self, number2):
        self.__number2 = number2

    @property
    def Number3(self):
        return self.__number3

    @Number3.setter
    def Number3(self, number3):
        self.__number3 = number3


    @abstractmethod
    def IncreaseNumber1(self, n):
        pass

    @abstractmethod
    def DecreaseNumber1(self, n):
        pass

    @abstractmethod
    def IncreaseNumber2(self, n):
        pass

    @abstractmethod
    def DecreaseNumber2(self, n):
        pass

    @abstractmethod
    def IncreaseNumber3(self, n):
        pass

    @abstractmethod
    def DecreaseNumber3(self, n):
        pass