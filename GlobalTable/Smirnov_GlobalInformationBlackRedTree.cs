using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_05_2021_Database_Coursework
{
    public class Smirnov_GlobalInformationBlackRedTree
    {
        public class TreeElem
        {
            public TreeElem left = null; // Левый потомок
            public TreeElem right = null; // Правый потомок
            public string color = "r"; // Цвет узла
            public GlobalInformation info; // Ключ узла
        };

        public TreeElem Head = null; // Корень дерева
        public MainFrame OriginFrame;

        private Smirnov_GlobalInformationBlackRedTree() { }
        public Smirnov_GlobalInformationBlackRedTree(MainFrame OriginFrame) { this.OriginFrame = OriginFrame; }

        // Рекурсивный вывод дерева
        // Формальные и входные параметры - нет
        // Выходные данные - значения элементов дерева, цвет элементов
        public string PrintTree()
        {
            OriginFrame.AddLog("Вывод дерева(возраста)");
            string result = "";
            print_Tree_Hidden(Head, 0, ref result);
            return result;
        }

        private void print_Tree_Hidden(TreeElem p, int level, ref string result)
        {
            if (p != null)
            {
                print_Tree_Hidden(p.right, level + 1, ref result);
                for (int i = 0; i < level; i++) result += "   ";
                result += p.info.Age + p.color + "\n";
                print_Tree_Hidden(p.left, level + 1, ref result);
            }
        }

        // Прямой обход(кто первый тот и выводится)
        // Формальные и входные параметры - корень дерева
        // Выходные данные - значения элементов дерева, цвет элементов
        public void print_NLR(TreeElem Head)
        {
            Console.Write(Head.info.Age + " ");
            if (Head.left != null) print_NLR(Head.left);
            if (Head.right != null) print_NLR(Head.right);
        }

        // Поиск родителя элемента-наследника(если таковой есть)
        // Формальные и входные параметры - корень дерева
        // Выходные данные - значения элементов дерева, цвет элементов
        public TreeElem GetParent(TreeElem child)
        {
            if (child == null) return null;
            TreeElem mover = Head;
            if (mover == child) return null;

            while (mover.left != child && mover.right != child)
            {
                if (child.info.Age >= mover.info.Age)
                    mover = mover.right;
                else mover = mover.left;
            }

            return mover;
        }


        // Очистка дерева от элементов
        // Формальные и входные параметры - дерево, корень дерева
        // Выходные данные - нет
        public void ClearTree()
        {
            Head = null;
            GC.Collect();
        }


        // Поворот налево
        // Формальные и входные параметры - дерево, узел который совершит поворот(отца указывать не надо)
        // Выходные данные - нет
        private void RotateLeft(TreeElem elem)
        {
            TreeElem Parent = GetParent(elem);
            TreeElem Grandparent = GetParent(Parent);

            Parent.right = elem.left;
            elem.left = Parent;
            if (Parent != Head)
            {
                if (Grandparent.left == Parent) Grandparent.left = elem;
                else if (Grandparent.right == Parent) Grandparent.right = elem;
            }
            else
            {
                Head = elem;
            }
        }


        // Поворот направо
        // Формальные и входные параметры - дерево, узел который совершит поворот(отца указывать не надо)
        // Выходные данные - нет
        private void RotateRight(TreeElem elem)
        {
            TreeElem Parent = GetParent(elem);
            TreeElem Grandparent = GetParent(Parent);

            Parent.left = elem.right;
            elem.right = Parent;
            if (Parent != Head)
            {
                if (Grandparent.right == Parent) Grandparent.right = elem;
                else if (Grandparent.left == Parent) Grandparent.left = elem;
            }
            else
            {
                Head = elem;
            }
        }


        // Поиск элемента в дереве по возрасту
        // Формальные и входные параметры - корень дерева, ключ элемента который нужно найти
        // Выходные данные - нужный элемент либо null, если элемента нет в древе
        public TreeElem FindElem(TreeElem elem, GlobalInformation info)
        {
            if (elem == null) return null;

            if (elem.info.Age == info.Age && elem.info.Login == info.Login) return elem;

            TreeElem ElementToReturn = FindElem(elem.left, info);
            if (ElementToReturn != null) return ElementToReturn;

            ElementToReturn = FindElem(elem.right, info);
            if (ElementToReturn != null) return ElementToReturn;

            return null;
        }

        // Поиск элемента в дереве по логину
        // Формальные и входные параметры - корень дерева, ключ элемента который нужно найти
        // Выходные данные - нужный элемент либо null, если элемента нет в древе
        public TreeElem FindElemByLogin(TreeElem elem, string login)
        {
            if (elem == null) return null;

            if (elem.info.Login == login) return elem;

            TreeElem ElementToReturn = FindElemByLogin(elem.left, login);
            if (ElementToReturn != null) return ElementToReturn;

            ElementToReturn = FindElemByLogin(elem.right, login);
            if (ElementToReturn != null) return ElementToReturn;

            return null;
        }

        // Находит максимальный элемент в древе/поддреве.
        // Формальные и входные параметры - корень древа
        // Выходные данные - максимальный элемент древа
        public TreeElem FindMaxElem(TreeElem elem)
        {
            if (elem == null) return null;

            while (elem.right != null)
            {
                elem = elem.right;
            }
            return elem;
        }


        // Находит минимальный элемент в древе/поддреве.
        // Формальные и входные параметры - корень древа
        // Выходные данные - минимальный элемент древа
        public TreeElem FindMinElem(TreeElem elem)
        {
            if (elem == null) return null;

            while (elem.left != null)
            {
                elem = elem.left;
            }
            return elem;
        }


        // Проверяет и выравнивает баланс черной глубины древа после добавления нового элемента.
        // Формальные и входные параметры - корень древа, добавленный элемент
        // Выходные данные - нет
        private void CheckBalance(TreeElem elem)
        {
            while (GetParent(elem) != null && GetParent(elem).color == "r")
            {
                TreeElem Parent = GetParent(elem);
                TreeElem Grandparent = GetParent(Parent);
                if (Parent == Grandparent.left)
                {
                    TreeElem Uncle = Grandparent.right;
                    // 1 случай
                    if (Uncle != null && Uncle.color == "r")
                    {
                        Parent.color = "b";
                        Uncle.color = "b";
                        Grandparent.color = "r";
                        elem = Grandparent;
                        if (elem == Head) elem.color = "b";
                    }
                    else
                    {
                        // 2 случай ИНОГДА
                        if (elem == Parent.right)
                        {
                            elem = Parent;
                            RotateLeft(elem.right);
                        }
                        Parent = GetParent(elem);
                        Grandparent = GetParent(Parent);
                        // 3 случай ВСЕГДА
                        Parent.color = "b";
                        Grandparent.color = "r";
                        RotateRight(Grandparent.left);
                    }
                }
                else
                {
                    TreeElem Uncle = Grandparent.left;
                    if (Uncle != null && Uncle.color == "r")
                    {
                        Parent.color = "b";
                        Uncle.color = "b";
                        Grandparent.color = "r";
                        elem = Grandparent;
                        if (elem == Head) elem.color = "b";
                    }
                    else
                    {
                        if (elem == Parent.left)
                        {
                            elem = Parent;
                            RotateRight(elem.left);
                        }
                        Parent = GetParent(elem);
                        Grandparent = GetParent(Parent);
                        Parent.color = "b";
                        Grandparent.color = "r";
                        RotateLeft(Grandparent.right);
                    }
                }
            }
            Head.color = "b";
        }

        // Добавляет новый элемент в древо, запускает ф-ю проверки баланса
        // Формальные и входные параметры - корень древа, ключ нового элемента
        // Выходные данные - нет
        public bool NewElem(GlobalInformation info)
        {
            if (FindElemByLogin(Head, info.Login) != null)
            {
                return false;
            }

            TreeElem newelem = new TreeElem();
            newelem.info = info;
            if (Head == null)
            {
                newelem.color = "b";
                Head = newelem;
            }
            else
            {
                TreeElem mover = Head;
                int newInfo = newelem.info.Age;
                while (true)
                {
                    if (newInfo >= mover.info.Age)
                    {
                        if (mover.right == null)
                        {
                            mover.right = newelem;
                            break;
                        }
                        mover = mover.right;
                    }
                    else
                    {
                        if (mover.left == null)
                        {
                            mover.left = newelem;
                            break;
                        }
                        mover = mover.left;
                    }
                }
                CheckBalance(newelem);
            }
            OriginFrame.AddLog("[Smirnov Black-Red-Tree] Добавлен новый элемент в дерево");
            OriginFrame.AddLog(PrintTree());
            return true;
        }


        // Удаляет элемент у которого нет детей, либо ребенок только один. Меняет корректно связи.
        // Вызывать функцию отдельно при удалении НЕ НАДО. Она сама вызывается в основной функции удаления
        // Формальные и входные параметры - корень древа, удаляемый элемент.
        // Выходные данные - нет
        private void DeleteElemSubfunc(TreeElem elem)
        {
            TreeElem Parent = GetParent(elem);
            if (Parent != null)
            {
                if (elem.left == null && elem.right == null)
                {
                    if (Parent.left == elem)
                    {
                        Parent.left = null;
                    }
                    else
                    {
                        Parent.right = null;
                    }
                }
                else if (elem.right != null)
                {
                    if (Parent.left == elem)
                    {
                        Parent.left = elem.right;
                    }
                    else
                    {
                        Parent.right = elem.right;
                    }
                }
                else if (elem.left != null)
                {
                    if (Parent.left == elem)
                    {
                        Parent.left = elem.left;
                    }
                    else
                    {
                        Parent.right = elem.left;
                    }
                }
            }
            else
            {
                Head = null;
            }
            elem = null;


        }

        // Проверяет и выравнивает баланс черной глубины древа после удаления элемента
        // Вызывать функцию отдельно при удалении НЕ НАДО. Она сама вызывается в основной функции удаления
        // Формальные и входные параметры - корень древа, родитель удаленного элемента
        // Выходные данные - нет
        private void DeleteBalance(TreeElem elem, TreeElem child)
        {
            if (elem == null) return;
            if (Head == null) return;

            TreeElem Parent = GetParent(elem);
            TreeElem Grandparent = GetParent(Parent);

            // Если был один ребенок(второй null), то он 100% красный. красим его в черный . правим баланс.
            if (child != null && child.color == "r") child.color = "b";
            // Изменилась черная высота, и это плохо!
            else
            {
                // Если удаленный элемент справа
                if (elem.right == null || elem.right == child)
                {
                    TreeElem lchild = elem.left;
                    if (elem.color == "r")
                    {
                        if (elem.left.color == "b")
                        {
                            if ((lchild.left == null || lchild.left.color == "b") && (lchild.right == null || lchild.right.color == "b"))
                            {
                                elem.color = "b";
                                lchild.color = "r";
                            }
                            else if (lchild.left.color == "r")
                            {
                                lchild.color = "r";
                                lchild.left.color = "b";
                                elem.color = "b";
                                RotateRight(lchild);
                            }
                        }
                    }
                    // Если родитель черный
                    else
                    {
                        if (lchild.color == "r")
                        {
                            // Если у правого потомка lchild черные дети
                            if (lchild.right != null && (lchild.right.left == null || lchild.right.left.color == "b") && (lchild.right.right == null || lchild.right.right.color == "b"))
                            {
                                lchild.color = "b";
                                lchild.right.color = "r";
                                RotateRight(lchild);
                            }
                            // Если у правого потомка lchild левый потомок красный
                            else if (lchild.right != null && lchild.right.left.color == "r")
                            {
                                lchild.right.left.color = "b";
                                RotateLeft(lchild.right);
                                RotateRight(elem.left);
                            }
                            else if (lchild.right.color == "r")
                            {
                                lchild.color = "b";
                                elem.color = "b";
                                RotateLeft(lchild.right);
                                RotateRight(elem.left);
                            }
                        }
                        // И левый потомок черный
                        else
                        {
                            if (lchild.right != null && lchild.right.color == "r")
                            {
                                lchild.right.color = "b";
                                RotateLeft(lchild.right);
                                RotateRight(elem.left);
                            }
                            else if ((lchild.left == null || lchild.left.color == "b") && (lchild.right == null || lchild.right.color == "b"))
                            {
                                lchild.color = "r";
                                DeleteBalance(GetParent(elem), elem);
                            }
                            else if (lchild.left != null && lchild.left.color == "r")
                            {
                                lchild.left.color = "b";
                                RotateRight(lchild);
                            }
                        }
                    }
                }
                // Если удаленный элемент слева
                else
                {
                    TreeElem rchild = elem.right;
                    if (elem.color == "r")
                    {
                        if (elem.right.color == "b")
                        {
                            // Есть a0014
                            if ((rchild.right == null || rchild.right.color == "b") && (rchild.left == null || rchild.left.color == "b"))
                            {
                                elem.color = "b";
                                rchild.color = "r";
                            }
                            // есть a0010
                            else if (rchild.right != null && rchild.right.color == "r")
                            {
                                rchild.color = "r";
                                rchild.right.color = "b";
                                elem.color = "b";
                                RotateLeft(rchild);
                            }
                            // есть !a0013
                            else if (rchild.left.color == "r")
                            {
                                rchild.color = "b";
                                elem.color = "b";
                                RotateRight(rchild.left);
                                RotateLeft(elem.right);
                            }
                        }
                    }
                    // Если родитель черный
                    else
                    {
                        if (rchild.color == "r")
                        {
                            // Если у правого потомка lchild черные дети
                            // да a0008
                            if (rchild.left != null && (rchild.left.right == null || rchild.left.right.color == "b") && (rchild.left.left == null || rchild.left.left.color == "b"))
                            {
                                rchild.color = "b";
                                rchild.left.color = "r";
                                RotateLeft(rchild);
                            }
                            // Если у правого потомка lchild левый потомок красный
                            // да !!a0013. По-своему балансирует, не так как визуализатор. Тем не менее баланс высот сохраняется
                            else if (rchild.left != null && rchild.left.right.color == "r")
                            {
                                rchild.left.right.color = "b";
                                RotateRight(rchild.left);
                                RotateLeft(elem.right);
                            }
                        }
                        // И левый потомок черный
                        else
                        {
                            //
                            if (rchild.left != null && rchild.left.color == "r")
                            {
                                rchild.left.color = "b";
                                RotateRight(rchild.left);
                                RotateLeft(elem.right);
                            }
                            // Есть !!a0008
                            else if ((rchild.right == null || rchild.right.color == "b") && (rchild.left == null || rchild.left.color == "b"))
                            {
                                rchild.color = "r";
                                DeleteBalance(GetParent(elem), elem);
                            }
                            // Есть !!a0010 (зеркально)
                            else if (rchild.right != null && rchild.right.color == "r")
                            {
                                rchild.right.color = "b";
                                RotateLeft(rchild);
                            }
                        }
                    }
                }
            }
        }

        // Основная функция удаления элемента из дерева. Удаляет элемент, вызывает функцию балансировки древа.
        // Формальные и входные параметры - древо, ключ удаляемого элемента
        // Выходные данные - нет
        public bool DeleteElem(GlobalInformation info)
        {
            TreeElem ElementToDelete = FindElem(Head, info);
            if (ElementToDelete == null) return false;

            TreeElem child = null;
            string elclr = ElementToDelete.color;
            TreeElem Parent = GetParent(ElementToDelete);
            if (ElementToDelete.left == null || ElementToDelete.right == null)
            {
                if (ElementToDelete.left != null) child = ElementToDelete.left;
                else if (ElementToDelete.right != null) child = ElementToDelete.right;

                DeleteElemSubfunc(ElementToDelete);
            }
            else
            {
                TreeElem max = FindMaxElem(ElementToDelete.left);

                if (max.left != null) child = max.left;
                else if (max.right != null) child = max.right;

                Parent = GetParent(max);
                elclr = max.color;
                DeleteElemSubfunc(max);
                ElementToDelete.info = max.info;
            }
            if (elclr == "b") DeleteBalance(Parent, child);
            OriginFrame.AddLog("[Smirnov Black-Red-Tree] Был удален элемент из дерева");
            OriginFrame.AddLog(PrintTree());
            return true;
        }


        public List<GlobalInformation> FindByInterval(int from, int to)
        {
            List<GlobalInformation> result = new List<GlobalInformation>();
            int comp = 0;
            TreeElem mover = Head;
            while (mover != null)
            {
                comp++;
                if (mover.info.Age == from)
                    break;
                if (mover.info.Age > from)
                    mover = mover.left;
                else
                    mover = mover.right;
            }
            mover = Head;
            while (mover != null)
            {
                comp++;
                if (mover.info.Age == to)
                    break;
                if (mover.info.Age > to)
                    mover = mover.left;
                else
                    mover = mover.right;
            }
            comp--;

            if (Head == null) return null;

            Stack<TreeElem> st = new Stack<TreeElem>();
            st.Push(Head);

            while (st.Count != 0)
            {
                TreeElem curEl = st.Pop();

                if (curEl.left != null)
                    st.Push(curEl.left);
                if (curEl.right != null)
                    st.Push(curEl.right);

                if (curEl.info.Age >= from && curEl.info.Age <= to)
                {
                    result.Add(curEl.info);
                }
            }

            OriginFrame.AddLog("[Smirnov Black-Red-Tree] Был совершен поиск по диапазону. Найдено подходящих элементов: " + result.Count + ", совершено сравнений: " + comp);
            return result;
        }
    }
}
