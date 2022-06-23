import Funcs
from TTriad import TTriad


class TDate(TTriad):
    def __init__(self, number1, number2, number3):
        super().__init__(number1, number2, number3)

    def IncreaseNumber1(self, n):
        self.Number1 += n
        while self.Number1 > 30:
            self.Number1 -= 30
            self.IncreaseNumber2(1)

    def DecreaseNumber1(self, n):
        self.Number1 -= n
        while self.Number1 <= 0:
            self.Number1 += 30
            self.DecreaseNumber2(1)


    def IncreaseNumber2(self, n):
        self.Number2 += n
        while self.Number2 > 12:
            self.Number2 -= 12
            self.IncreaseNumber3(1)

    def DecreaseNumber2(self, n):
        self.Number2 -= n
        while self.Number2 <= 0:
            self.Number2 += 12
            self.DecreaseNumber3(1)


    def IncreaseNumber3(self, n):
        self.Number3 += n

    def DecreaseNumber3(self, n):
        self.Number3 -= n

    def Output(self):
        print(f"{Funcs.ChangeFormat(self.Number1)}.{Funcs.ChangeFormat(self.Number2)}.{Funcs.ChangeFormat(self.Number3)}")