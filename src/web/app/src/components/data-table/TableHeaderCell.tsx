import styled from 'styled-components';

export const TableHeaderCell = styled.th``;

export type TableHeaderCellProps = {
  sortIcon?: string;
  sortDirection?: 'asc' | 'desc';
  //   label: string;
  children: React.ReactNode;
};
export default function View({
  children,
}: TableHeaderCellProps) {
  return <th>{children}</th>;
}
