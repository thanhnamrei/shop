import { Row } from '@/components/box/Row';

type PublicLayoutProps = {
  children: React.ReactNode;
};

const View = ({ children }: PublicLayoutProps) => {
  return (
    <div>
      <header>
        <Row mainAxisAlignment="end" gap={2}>
          <span>Trợ giúp</span>
          <span>English</span>|<span>Tiếng Việt</span>
        </Row>
        <Row></Row>
      </header>
      <main>{children}</main>
      <footer></footer>
    </div>
  );
};
export default View;
