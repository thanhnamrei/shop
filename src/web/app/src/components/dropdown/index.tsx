export type DropdownOption = {
  key: string;
  text: string;
  type?: string;
};

export type DropdownProps = {
  options: DropdownOption[];
  placeholder: string;
};

const View = () => {
  return <input type="text" />;
};
export default View;
